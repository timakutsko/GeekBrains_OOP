using System;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "Шла Саша по шоссе, и сосала невесть что!";
            ACoder aCoder = new ACoder(myString1);
            string myCodeString1 = aCoder.Encode();
            string myDecodeString1 = aCoder.Decode();

            string myString2 = "Шла Саша по шоссе, и сосала невесть что!";
            BCoder bCoder = new BCoder(myString2);
            string myCodeString2 = bCoder.Encode();
            string myDecodeString2 = bCoder.Decode();

            Console.ReadLine();
        }
    }
}
