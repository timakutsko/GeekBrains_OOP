using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt bAcc_1 = new BankAccaunt();
            _ = bAcc_1.Print;

            BankAccaunt bAcc_2 = new BankAccaunt(555);
            _ = bAcc_2.Print;

            BankAccaunt bAcc_3 = new BankAccaunt(AccauntType.Savings);
            _ = bAcc_3.Print;

            BankAccaunt bAcc_4 = new BankAccaunt(666, AccauntType.Savings);
            _ = bAcc_4.Print;
        }
    }
}
