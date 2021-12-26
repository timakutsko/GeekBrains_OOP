using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt bAcc_1 = new BankAccaunt();
            bAcc_1.PrintAccaunt();

            BankAccaunt bAcc_2 = new BankAccaunt(555);
            bAcc_2.PrintAccaunt();

            BankAccaunt bAcc_3 = new BankAccaunt(AccauntType.Savings);
            bAcc_3.PrintAccaunt();

            BankAccaunt bAcc_4 = new BankAccaunt(666, AccauntType.Savings);
            bAcc_4.PrintAccaunt();
        }
    }
}
