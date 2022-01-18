using System;

namespace BankAccaount_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Accaunt acc1 = new Accaunt(1000, AccauntType.Savings, true);
            Accaunt acc2 = new Accaunt(5000, AccauntType.Budget, true);
            Accaunt acc3 = acc1;
            Accaunt acc4 = new Accaunt(50, AccauntType.ForeignCurrency, false);
            Accaunt acc5 = new Accaunt(50, AccauntType.ForeignCurrency, false);

            bool isEqual12 = acc1 == acc2;
            bool isEqual13 = acc1 == acc3;
            bool isNotEqual12 = acc1 != acc2;
            bool isEquals12 = acc1.Equals(acc2);
            bool isEquals13 = acc1.Equals(acc3);
            bool isEquals45 = acc4.Equals(acc5);
            int hashCode1 = acc1.GetHashCode();
            int hashCode4 = acc2.GetHashCode();
            int hashCode5 = acc2.GetHashCode();
            string str1 = acc1.ToString();
            string str2 = acc5.ToString();


            Console.ReadLine();
        }
    }
}
