namespace DnBuild
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = ConfigSettings.Tittle;
            Console.WriteLine(ConfigSettings.Enable ? "[MYTEST]" : "Default");
            Console.ReadLine();
        }
    }
}