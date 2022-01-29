using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTS.FileManager.Core
{
    public interface IUserCommandInfoStr : IUserCommand
    {
        public IReadOnlyCollection<string> Execute(string path);
    }
}
