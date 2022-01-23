using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal sealed class ACoder : ICoder
    {
        private string _inputString;
        private string _outputString;

        public string InputString
        {
            set { _inputString = value; }
        }  
        
        public ACoder(string input)
        {
            _inputString = input;
        }

        public string Decode() => CoderDecoder(-1, _outputString);

        public string Encode() => _outputString = CoderDecoder(1, _inputString);

        private string CoderDecoder(int index, string str)
        {
            StringBuilder stringBuilder = new StringBuilder(str.Length);
            foreach (char c in str)
            {
                if (Char.IsWhiteSpace(c) || Char.IsDigit(c) || Char.IsPunctuation(c))
                {
                    stringBuilder.Append(c);
                }
                else
                {
                    stringBuilder.Append((char)((int)c + index));
                }
            }
            return stringBuilder.ToString();
        }
    }
}
