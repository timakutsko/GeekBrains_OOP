using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTS.FileManager.Commands.Core
{
    enum Command
    {
        Exit = 0,
        Dir = 1,
        Create = 2,
        Delete = 3,
        Rename = 4,
        Copy = 5,
        Size = 6,
        FindByMask = 7,
        StaticData = 8,
    }
    public class ExitComand : ICommand
    {
        public int Type
        {
            get
            {
                return (int)Command.Exit;
            }
        }

        public void Execut()
        {
            throw new NotImplementedException();
        }
    }

    public class DirComand : ICommand
    {
        public int Type
        {
            get
            {
                return (int)Command.Dir;
            }
        }

        public void Execut()
        {
            throw new NotImplementedException();
        }
    }

    public class CreateComand : ICommand
    {
        public int Type
        {
            get
            {
                return (int)Command.Create;
            }
        }

        public void Execut()
        {
            throw new NotImplementedException();
        }
    }
}
