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
            Console.WriteLine(new string('\uFF3F', Console.WindowWidth));
        }

        public void GenerateId()
        {
            Random rand = new Random();
            uint autoId = (uint)rand.Next(10000000, 99999999);
            _id = autoId;
        }

        public void TransactionAdd(int summ)
        {
            _balance += summ;
            Console.WriteLine($"На счет внесено: {summ}");
            Console.WriteLine($"Баланс: {_balance}");
        }

        public void TransactionTakeAway(int summ)
        {
            if (summ > _balance)
            {
                Console.WriteLine($"Недостаточно средств! Максимально доступная сумма: {_balance}");
            }
            else
            {
                _balance -= summ;
                Console.WriteLine($"Со счета снято: {summ}");
                Console.WriteLine($"Баланс: {_balance}");
            }
        }

    }
}
