using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data.Commands
{
    public sealed class Create : IUserCommandActionStrStr
    {
        public int Type
        {
            get 
            { 
                return (int)Command.Create; 
            }
        }

        public void Execute(string path, string pivot)
        {
            string fullPath = Path.Combine(path, ".", pivot);
            File.Create(fullPath);
        }
    }
}
