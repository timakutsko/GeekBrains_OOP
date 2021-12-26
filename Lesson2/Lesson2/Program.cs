using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt bAcc_1 = new BankAccaunt();
            bAcc_1.Id = 12345678;
            bAcc_1.Balance = 155;
            bAcc_1.AccauntType = AccauntType.Budget;
            bAcc_1.PrintAccaunt();

            BankAccaunt bAcc_2 = new BankAccaunt();
            bAcc_2.GenerateId();
            bAcc_2.Balance = 100;
            bAcc_2.AccauntType = AccauntType.Savings;
            bAcc_2.PrintAccaunt();
            
        }
    }
}
