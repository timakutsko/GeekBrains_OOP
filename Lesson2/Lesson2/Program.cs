using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt bAcc_1 = new BankAccaunt(0);
            bAcc_1.PrintAccaunt();
            bAcc_1.TransactionAdd(75);
            bAcc_1.TransactionTakeAway(150);
            Console.WriteLine(new string('\uFF3F', Console.WindowWidth));

            BankAccaunt bAcc_2 = new BankAccaunt(100);
            bAcc_2.PrintAccaunt();
            bAcc_2.TransactionAdd(75);
            bAcc_2.TransactionTakeAway(150);
        }
    }
}
