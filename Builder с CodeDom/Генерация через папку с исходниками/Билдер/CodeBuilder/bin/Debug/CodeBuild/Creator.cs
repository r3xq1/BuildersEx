namespace CodeBuild
{
    using System;
    using System.IO;

    public static class Creator
    {
        static bool Enable = [BOOL]; // Простая переменная

        static readonly string CurrFilePath = Path.Combine(Environment.CurrentDirectory, "TestFile.txt"); // Текущий файл в который записываем текст

        public static void Inizialize()
        {
            if (Enable)
            {
                File.WriteAllText(CurrFilePath, "Enable = true");
            }
            else
            {
                File.WriteAllText(CurrFilePath, "Enable = false");
            }
        }
    }
}