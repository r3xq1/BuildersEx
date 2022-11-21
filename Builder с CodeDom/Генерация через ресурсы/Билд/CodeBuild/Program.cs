namespace CodeBuild
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "CodeDom Build Edition";
            Console.WriteLine("[Message]");
            Creator.Inizialize();
            Console.ReadLine();
        }
    }
}