using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTS.FileManager.Data
{
    public sealed class UserException : Exception
    {
        public UserException(string discr, string message) : base(String.Format("{0}. {1}", discr, message))
        {

        }
    }
}
