namespace StubWinBuilder
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.CSharp;
    using Properties;

    public static class SourceEditor
    {
        public static void TestFunction(string consoleText, string MsgBox)
        {
            Dictionary<string, string> providerOptions = new() { { "CompilerVersion", "v4.0" } };

            string SourceCode = Resources.StubWinForms; // Загружаем текстовый файл из ресурсов
            SourceCode = SourceCode.Replace("[CONSOLE]", consoleText);
            SourceCode = SourceCode.Replace("[TEST]", MsgBox);
            SourceCode = SourceCode.Replace("#Title#", "Это сообщение заголовок");
            using CSharpCodeProvider provider = new(providerOptions);
            // Дефолтные параметры для компиляции
            var parameters = new CompilerParameters
            {
                OutputAssembly = "Build.exe", // Выходной файл .exe
                CompilerOptions = $"/target:winexe /optimize+ /platform:anycpu", // Дополнительные параметры для компиляции
                TreatWarningsAsErrors = false,
                GenerateInMemory = true,
                IncludeDebugInformation = false,
                GenerateExecutable = true, // Генерация в .exe
                // Библиотеки которые необходимо подключить в проект, пишешь тут
                ReferencedAssemblies = { "System.dll", "System.Drawing.dll", "System.Windows.Forms.dll",  }
            };
            // Компиляция!
            CompilerResults ResultLog = provider.CompileAssemblyFromSource(parameters, SourceCode);
            // Проверка на ошибки
            if (!ResultLog.Errors.HasErrors)
            {
                Console.WriteLine("Компиляция прошла успешно!");
                MessageBox.Show("Компиляция прошла успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Найдены ошибки при компиляции!");
                using StreamWriter log_Error = File.AppendText("Error_Compile.txt");
                // Проходимся циклом чтобы перечислить все ошибки которые возникли и записать их в файл .txt
                foreach (CompilerError compilerError in ResultLog.Errors)
                {
                    log_Error.WriteLine($"Error: {compilerError} \r\nLine: {compilerError.Line}\r\n");
                }
            }
        }
    }
}