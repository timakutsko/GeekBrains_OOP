using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    
    class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber() : this (0, 1)
        {
        }
        
        public RationalNumber (int numer, int denom)
        {
            _numerator = numer;
            _denominator = denom;
        }
        
        public static bool operator ==(RationalNumber n1, RationalNumber n2)
        {
            return (n1.Denominator == n2.Denominator && n1.Numerator == n2.Numerator);
        }

        public static bool operator !=(RationalNumber n1, RationalNumber n2)
        {
            return (n1.Denominator != n2.Denominator || n1.Numerator != n2.Numerator);
        }

        public static bool operator <(RationalNumber n1, RationalNumber n2)
        {
            if(n1.Denominator == n2.Denominator)
            {
                return (n1.Numerator < n2.Numerator);
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                return (temp1 < temp2);
            }
        }

        public static bool operator >(RationalNumber n1, RationalNumber n2)
        {
            if (n1.Denominator == n2.Denominator)
            {
                return (n1.Numerator > n2.Numerator);
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                return (temp1 > temp2);
            }
        }

        public static bool operator <=(RationalNumber n1, RationalNumber n2)
        {
            if (n1.Denominator == n2.Denominator)
            {
                return (n1.Numerator <= n2.Numerator);
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                return (temp1 <= temp2);
            }
        }

        public static bool operator >=(RationalNumber n1, RationalNumber n2)
        {
            if (n1.Denominator == n2.Denominator)
            {
                return (n1.Numerator >= n2.Numerator);
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                return (temp1 >= temp2);
            }
        }

        public static RationalNumber operator +(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber res = new RationalNumber();
            if (n1.Denominator == n2.Denominator)
            {
                res.Numerator = n1.Numerator + n2.Numerator;
                res.Denominator = n1.Denominator;
                return res;
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                res.Numerator = temp1 + temp2;
                res.Denominator = overallDenominator;
                return res;
            }
        }

        public static RationalNumber operator ++(RationalNumber n1)
        {
            n1.Numerator += 1;
            return n1;
        }

        public static RationalNumber operator -(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber res = new RationalNumber();
            if (n1.Denominator == n2.Denominator)
            {
                res.Numerator = n1.Numerator - n2.Numerator;
                res.Denominator = n1.Denominator;
                return res;
            }
            else
            {
                int overallDenominator = n1.Denominator * n2.Denominator;
                int temp1 = overallDenominator / n1.Denominator * n1.Numerator;
                int temp2 = overallDenominator / n2.Denominator * n2.Numerator;
                res.Numerator = temp1 - temp2;
                res.Denominator = overallDenominator;
                return res;
            }
        }

        public static RationalNumber operator --(RationalNumber n1)
        {
            n1.Numerator -= 1;
            return n1;
        }

        public static RationalNumber operator *(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber res = new RationalNumber();
            res.Numerator = n1.Numerator * n2.Numerator;
            res.Denominator = n1.Denominator * n2.Denominator;
            return res;
        }

        public static RationalNumber operator /(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber res = new RationalNumber();
            res.Numerator = n1.Numerator * n2.Denominator;
            res.Denominator = n1.Denominator * n2.Numerator;
            return res;
        }

        public static explicit operator float(RationalNumber rn)
        {
            return rn.Numerator / (float)rn.Denominator;
        }

        public static explicit operator int(RationalNumber rn)
        {
            return rn.Numerator / rn.Denominator;
        }

        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                _denominator = value;
            }
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                var number = (RationalNumber)obj;
                return (Numerator == number.Numerator) && (Denominator == number.Denominator);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format($"{Numerator}/{Denominator}");
        }
    }
}
