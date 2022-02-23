using System;

namespace StringRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку:");
            char[] chArr = Console.ReadLine().ToCharArray();
            string revStr = string.Empty;
            for (int i = chArr.Length - 1; i >= 0; i--)
            {
                revStr += string.Concat(chArr[i]);
            }
            Console.WriteLine($"Реверс: {revStr}");
        }
    }
}