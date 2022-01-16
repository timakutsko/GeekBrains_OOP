using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1 = new RationalNumber(2, 5);
            RationalNumber number2 = new RationalNumber(1, 3);
            RationalNumber number3 = new RationalNumber(2, 6);
            int number4 = 5;
            RationalNumber number5 = new RationalNumber(1, 3);

            bool eq12 = number1 == number2;
            bool eq13 = number1 == number3;
            bool eq23 = number2 == number3;

            bool nEq12 = number1 != number2;
            bool nEq13 = number1 != number3;
            bool nEq23 = number2 != number3;

            bool ovEq12 = number1.Equals(number2);
            bool ovEq13 = number1.Equals(number3);
            bool ovEq14 = number1.Equals(number4);

            bool bigger12 = number1 > number2;
            bool bigger21 = number2 > number1;
            bool bigger13 = number1 > number3;

            bool smaller12 = number1 < number2;
            bool smaller13 = number1 < number3;

            bool smallerOrEq12 = number1 <= number2;
            bool smallerOrEq35 = number3 <= number5;

            RationalNumber number12 = number1 + number2;
            RationalNumber number13 = number1 + number3;

            number12++;
            number13--;

            RationalNumber number1m2 = number1 * number2;
            RationalNumber number1d2 = number1 / number2;

            float floatNumb = (float)number1d2;
            int intNumb = (int)number1d2;

            Console.WriteLine(floatNumb.ToString());
            Console.WriteLine(intNumb.ToString());
            Console.WriteLine(number12.ToString());
            Console.WriteLine(smallerOrEq12.ToString());
            Console.WriteLine(number1m2.ToString());
        }
    }
}
