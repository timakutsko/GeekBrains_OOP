using System;
using System.IO;

namespace Lesson3_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"emails.txt";
            string newPath = @"justEmails.txt";
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(newPath);
            
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                SearchMail(ref line);
                sw.WriteLine(line);
            }
            sr.Close();
            sw.Close();
        }
        
        public static void SearchMail(ref string s)
        {
            s = s.Split('&')[1].Trim();
        }

    }
}
