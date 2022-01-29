using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTS.FileManager.Core
{
    public interface IUserCommandActionStrStr : IUserCommand
    {
        public void Execute(string path, string pivot);
    }
}
