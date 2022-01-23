using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal sealed class BCoder : ICoder
    {
        private string _inputString;
        private string _outputString;

        public string InputString
        {
            set { _inputString = value; }
        }

        public BCoder(string input)
        {
            _inputString = input;
        }

        public string Decode() => CoderDecoder(_outputString, (int)'Я', (int)'я', -31);

        public string Encode() => _outputString = CoderDecoder(_inputString, (int)'А', (int)'а', 31);

        private string CoderDecoder(string str, int bigNumb, int smallNumb, int letters)
        {
            StringBuilder stringBuilder = new StringBuilder(str.Length);
            foreach (char c in str)
            {
                if (Char.IsWhiteSpace(c) || Char.IsDigit(c) || Char.IsPunctuation(c))
                {
                    stringBuilder.Append(c);
                }
                else if(Char.IsUpper(c))
                {
                    stringBuilder.Append((char)(bigNumb + letters - (c - bigNumb)));
                }
                else
                {
                    stringBuilder.Append((char)(smallNumb + letters - (c - smallNumb)));
                }
            }
            return stringBuilder.ToString();
        }
    }
}
