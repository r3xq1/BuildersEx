namespace DnBuilder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using dnlib.DotNet;
    using dnlib.DotNet.Emit;
    using dnlib.DotNet.Writer;
    using Properties;

    public partial class BuilderFrm : Form
    {
        readonly string PathOutBuild = Path.Combine(Environment.CurrentDirectory, "Build.exe");
        public BuilderFrm()
        {
            InitializeComponent();
        }

        private void ConsoleBox_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = null; // Убираем фокус с кнопки
            ConsoleTextBox.Enabled = ConsoleBox.Checked; // Проверка актива кнопки
        }

        private void BuilderGo_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            // Чтобы GUI не стопорилась 
            using var task = Task.Factory.StartNew(() =>
            {
                try
                {
                    // Загружаем уже скомпилированный билд
                    using var module = ModuleDefMD.Load(Resources.DnBuild);
                    module.Kind = ModuleKind.Console; // тип выходных данных: Console - консольное приложение | Windows - приложение с формой


                    // Получаем все типы классов в сборке
                    foreach (TypeDef type in module.GetTypes())
                    {
                        // Проверяем что тип имеет методы
                        if (type.HasMethods)
                        {
                            // Перебираем все мтоды - проверяем при этом что есть в теле метода инструкции
                            foreach (MethodDef method in type.Methods.Where(method => method.HasBody && method.Body.HasInstructions))
                            {
                                // Все инструкции в конструкторе
                                IList<Instruction> instr = method.Body.Instructions;
                                // Перебираем инструкции
                                for (int i = 0; i < instr.Count; i++)
                                {
                                    // Из всех классов нас интересует класс: ConfigSettings.cs, находим его и находим в нём строчку "TEST"
                                    if (type.Name.Equals("ConfigSettings") && instr[i].OpCode.Equals(OpCodes.Ldstr) && instr[i].Operand.ToString().Equals("TEST", StringComparison.OrdinalIgnoreCase))
                                    {
                                        // И заменяем на нашу
                                        instr[i].Operand = ConsoleTittleBox.Text; // текст из текстбокса
                                    }
                                    if (ConsoleBox.Checked)
                                    {
                                        // Из класса: ConfigSettings.cs находим поле "Enable" и заменяем его
                                        if (type.Name.Equals("ConfigSettings") && instr[i].Operand is FieldDef fieldExt && fieldExt.Name.Equals("Enable"))
                                        {
                                            // Ldc_I4_1 = bool true | Ldc_I4_0 = bool false
                                            instr[i - 1].OpCode = ConsoleBox.Checked ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0;
                                        }
                                        if (type.Name.Equals("Program") && instr[i].OpCode.Equals(OpCodes.Ldstr) && instr[i].Operand.ToString().Equals("[MYTEST]", StringComparison.OrdinalIgnoreCase))
                                        {
                                            // И заменяем на нашу
                                            instr[i].Operand = ConsoleTextBox.Text; // текст из текстбокса
                                        }
                                    }
                                }

                                #region Оптимизация инструкций
                                // Оптимизация и упрощение инструкций
                                instr.SimplifyBranches(); // Упрощение инструкций(br.s -> br)
                                instr.OptimizeBranches(); // Оптимизация всех условий,  "впаивание" наших IL-инструкций в тело метода.
                                // instr.OptimizeMacros(); // Оптимизация макросов  (используется, если используется SimplifyMacros )
                                instr.UpdateInstructionOffsets(); // Обновляет все смещения инструкций
                                #endregion
                            }
                        }
                    }

                    // Параметры записи
                    ModuleWriterOptions opts = new(module);
                    // Обход ошибки: KeepOldMaxStack
                    opts.MetadataOptions.Flags |= MetadataFlags.KeepOldMaxStack | MetadataFlags.PreserveAll;
                    opts.MetadataLogger = DummyLogger.NoThrowInstance;
                    module.Write(PathOutBuild, opts);
                    MessageBox.Show("Билд создан успешно!", "DnBuilder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.Beep();
                    File.WriteAllText("Error_Builder.txt", $"Ошибка: {ex.Message}\r\nFull Error: \n{ex}");
                }
            });
            task.Wait(); // Ожидаем
            // ... Далее что-то делаем
        }
    }
}