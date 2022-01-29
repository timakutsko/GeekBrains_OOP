using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data.Commands
{
    public sealed class Remove : IUserCommandActionStrStr
    {
        public int Type
        {
            get
            {
                return (int)Command.Remove;
            }
        }

        public void Execute(string path, string pivot)
        {
            throw new NotImplementedException();
        }
    }
}
