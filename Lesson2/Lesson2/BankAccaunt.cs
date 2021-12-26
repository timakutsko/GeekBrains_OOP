using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    enum AccauntType
    {
        Budget,
        ForeignCurrency,
        Savings,
    }
    
    class BankAccaunt
    {
        private uint _id;
        private int _balance;
        private AccauntType _type;

        public BankAccaunt() : this(0, AccauntType.Budget)
        {
        }

        public BankAccaunt(int Balance) : this(Balance, AccauntType.Budget)
        {
        }

        public BankAccaunt(AccauntType AccType) : this(0, AccType)
        {
        }

        public BankAccaunt(int Balance, AccauntType AccType)
        {
            this.GenerateId();
            _balance = Balance;
            _type = AccType;
        }

        public void PrintAccaunt()
        {
            Console.WriteLine($"Id счета: {_id}");
            Console.WriteLine($"Баланс счета: {_balance}");
            Console.WriteLine($"Тип счета: {_type}");
        }

        public void GenerateId()
        {
            Random rand = new Random();
            uint autoId = (uint)rand.Next(10000000, 99999999);
            _id = autoId;
        }

    }
}
