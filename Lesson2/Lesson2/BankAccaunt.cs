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

        public uint Id
        {
            get
            {
                return _id;
            }
            set
            {
                string strId = value.ToString();
                if(strId.Length < 8 || strId.Length > 8)
                {
                    _id = 0;
                    Console.WriteLine("Номер счета содержит 8 символов!");
                }
                _id = value;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public AccauntType AccauntType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
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
            Id = autoId;
        }

    }
}
