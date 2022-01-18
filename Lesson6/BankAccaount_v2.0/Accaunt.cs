using System;

namespace BankAccaount_v2
{
    enum AccauntType
    {
        Budget,
        ForeignCurrency,
        Savings,
    }

    internal sealed class Accaunt
    {
        private int _id;
        private int _balance;
        private AccauntType _type;

        public Accaunt() : this(0, AccauntType.Budget, false)
        {
        }

        public Accaunt(int Balance) : this(Balance, AccauntType.Budget, false)
        {
        }

        public Accaunt(AccauntType AccType) : this(0, AccType, false)
        {
        }

        public Accaunt(int Balance, AccauntType AccType) : this(Balance, AccType, false)
        {
            this.GenerateId();
            _balance = Balance;
            _type = AccType;
        }
        
        public Accaunt(int Balance, AccauntType AccType, bool isAutoId)
        {
            if (isAutoId)
            {
                this.GenerateId();
            }
            else
            {
                _id = -1;
            }
            _balance = Balance;
            _type = AccType;
        }

        public void GenerateId()
        {
            Random rand = new Random();
            int autoId = rand.Next(10000000, 99999999);
            _id = autoId;
        }

        public static bool operator ==(Accaunt acc1, Accaunt acc2)
        {
             return (acc1._id == acc2._id && acc1._balance == acc2._balance && acc1._type == acc2._type);
        }

        public static bool operator !=(Accaunt acc1, Accaunt acc2)
        {
            return (acc1._id != acc2._id && acc1._balance != acc2._balance && acc1._type != acc2._type);
        }

        public override bool Equals(object obj)
        {

            if (ReferenceEquals(this, (Accaunt)obj))
            {
                return false;
            }
            return (this == (Accaunt)obj);
        }

        public override int GetHashCode()
        {
            return (_id, _balance).GetHashCode();
        }

        public override string ToString()
        {
            if(_balance < 100)
            {
                return $"{_balance} - это не деньги. Забери карту и не позорься!";
            }
            else
            {
                return $"Id счета: {_id}, баланс {_balance}";
            }
        }
    }
}