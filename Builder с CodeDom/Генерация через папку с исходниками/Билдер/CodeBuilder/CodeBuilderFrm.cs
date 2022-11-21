namespace CodeBuilder
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.CSharp;

    public partial class CodeBuilderFrm : Form
    {
        public CodeBuilderFrm()
        {
            InitializeComponent();
        }

        private void SelectIcon_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            using var Open = new OpenFileDialog
            {
                Title = "Iconka for Build",
                Filter = "Icon (*.ico)|*.ico",
                Multiselect = false,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                RestoreDirectory = true
            };

            if (Open.ShowDialog() == DialogResult.OK)
            {
                IcoPath.Text = Open.FileName;
                if (File.Exists(IcoPath.Text))
                {
                    IcoViewer.ImageLocation = IcoPath.Text;
                }
            }
            else
            {
                IcoPath.Clear();
                IcoViewer.Image = null;
            }
        }

        private void GenAss_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            AssProductTextBox.Text = GenX.RandomString(7, false);
            AssTitleTextBox.Text = GenX.RandomString(15, false);
            AssDescriptTextBox.Text = GenX.RandomString(15, false);
            AssCompanyTextBox.Text = GenX.RandomString(7, false);
            AssCopyrightTextBox.Text = GenX.RandomString(15, false);
            AssVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            AssFileVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            AssGuidTextBox.Text = Guid.NewGuid().ToString();
        }

        // Текущий путь до папки с исходниками
        readonly string SourcePath = Path.Combine(Environment.CurrentDirectory, "CodeBuild"); 

        private void CompileBuild_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            // Находим папку с файлами
            LogBox.Clear();
            DirectoryInfo di = new(SourcePath);
            if (di.Exists) // Если папка существует
            {
                string SourceCode = ""; // создём пустую переменную SourceCode типа string
                LogBox.Text += $"[+] Найдены исходные коды:\r\n";
                LogBox.Text += $"[+] Подключаем аттрибуты файла: AssemblyInfo.cs\r\n";
                // Всегда аттрибуты сборки должны быть первым по списку в компиляции, поэтому загружаем файл AssemblyInfo первым
                SourceCode += File.ReadAllText(Path.Combine(di.FullName, @"Properties\AssemblyInfo.cs"));
                // Проходимся по списку и ищем все файлы с расширением .cs во всех папках и подпапках (текущей папки)
                foreach (string search in Directory.EnumerateFiles(di.FullName, "*.cs", SearchOption.AllDirectories))
                {
                    LogBox.Text += $"    {search}\r\n"; // Уведомляем какие папки нашлись
                    // Исключаем из поиска файл AssemblyInfo.cs
                    if (!search.Contains("AssemblyInfo")) 
                    {
                        SourceCode += File.ReadAllText(search); // Загружаем остальные классы для замены
                        LogBox.Text += $"[+] Загрузили файл: {Path.GetFileName(search)}\r\n";
                    }
                }
                SourceCode = SourceCode.Replace("[Message]", MessageTextBox.Text); // Заменяем текст на текст из текстбокса
                LogBox.Text += $"[+] Заменили текст сообщения на:    {MessageTextBox.Text}\r\n";
                // P.S: Обязательно Checked.ToString().ToLower() - чтобы bool была с маленькой а не с большой False/True
                SourceCode = SourceCode.Replace("[BOOL]", checkBox1.Checked.ToString().ToLower()); // bool переменные заменяем как текст
                LogBox.Text += $"[+] bool переменная Enable: {checkBox1.Checked.ToString().ToLower()}\r\n";

                #region Замена свойст билд файла
                SourceCode = SourceCode.Replace("[TITLE]", AssTitleTextBox.Text).
                                  // Replace("[DESCRIPTION]", AssDescriptTextBox.Text).
                                   Replace("[COMPANY]", AssCompanyTextBox.Text).
                                   Replace("[PRODUCT]", AssProductTextBox.Text).
                                   Replace("[COPYRIGHT]", AssCopyrightTextBox.Text).
                                   Replace("[VERSION]", AssVerTextBox.Text).
                                   Replace("[FILEVERSION]", AssFileVerTextBox.Text).
                                   Replace("[GUID]", AssGuidTextBox.Text);
                #endregion

               // Версия .Net Framework для билда
               Dictionary<string, string> providerOptions = new() { ["CompilerVersion"] = "v4.0" };

                // Инициализация нового экземпляра класса CSharpCodeProvider
                using CSharpCodeProvider provider = new(providerOptions);

                // Дефолтные параметры для компиляции (https://learn.microsoft.com/ru-ru/dotnet/api/system.codedom.compiler.compilerparameters?view=dotnet-plat-ext-7.0)
                CompilerParameters parameters = new()
                {
                    OutputAssembly = $"{NameOutput.Text}.exe", // Выходной файл .exe
                    CompilerOptions = $"/target:{(checkBox2.Checked ? "winexe" : "exe")} /optimize+ /platform:anycpu", // Дополнительные параметры для компиляции
                    TreatWarningsAsErrors = false, // Убираем предупреждения как ошибки при компиляции
                    GenerateInMemory = false, // Генерация сборки в памяти (можно использовать MemoryStream) и не создавать локально =)
                    IncludeDebugInformation = false, // Дебажная информация
                    GenerateExecutable = true, // Создаём .exe файл на выходе
                    // Какие библиотеки есть в Вашем билде (исходниках) такие добавляйте и тут для подгрузки
                    // P.S: Если есть какие-то локальные, то указывайте полный путь до библиотеки.
                    ReferencedAssemblies = { "System.dll", "System.Windows.Forms.dll", }
                };
                LogBox.Text += $"[+] Тип выходных данных: {(checkBox2.Checked ? "Windows Forms Application" : "Console Application")}\r\n";
                if (ErrorBox.Checked) // Проверка на включения CheckBox'a
                {
                    parameters.IncludeDebugInformation = true;
                    parameters.TempFiles = new TempFileCollection(".", true); // Генерирует temp файлы с ошибками в текущую папку с файлом
                }

                if (!string.IsNullOrEmpty(IcoPath.Text)) // Проверка на обнаружение иконки
                {
                    parameters.CompilerOptions += $" /win32icon:{Path.GetFullPath(IcoPath.Text.Trim())}"; // Добавляем иконку (путь не должен содержать пробелы!)
                    LogBox.Text += $"[+] Добавили иконку: {IcoPath.Text}\r\n";
                }
                // parameters.CompilerOptions += $" /win32manifest:{GlobalPath.ManifestFile}"; // внедряем запуск от Админа (укажите путь до манифеста)

                // Компиляция!
                LogBox.Text += $"[+] Компилируем проект\r\n";
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, SourceCode);
                // Проверка компиляции на ошибки
                if (!results.Errors.HasErrors)
                {
                    LogBox.Text += $"[✓] Компиляция прошла успешно!\r\n";
                    //MessageBox.Show("Билд создан успешно!", "CodeBuilder [CodeDom] Special for You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LogBox.Text += $"[Х] Ошибка компиляции, проверьте файл с ошибками рядом с билдером!\r\n";
                    // Если есть ошибки пройдёмся циклом и запишем их все в текстовый файл
                    foreach (CompilerError compilerError in results.Errors)
                    {
                        // compilerError - Список всех ошибок | compilerError.Line - на какой строке ошибка (чтобы было удобнее ориентироваться для исправления)
                        File.WriteAllText("Error_Compiler.txt", $"Ошибка: {compilerError} \r\nСтрока: {compilerError.Line}\r\n{compilerError.FileName}");
                    }
                }
            }
            else
            {
                LogBox.Text += $"[�] Исходные файлы для компиляции не обнаружены!!\r\n";
                // Папки с исходниками нету!
            }
        }
    }
}