using System.IO;
using System.Collections;

namespace KTS.FileManager.Data.Commands
{
    public sealed class CommandDirectory : Core.IUserCommand
    {
        public int Type
        {
            get 
            { 
                return (int)Core.Command.Dir; 
            }
        }

        public string Name
        {
            get
            {
                return "DIR";
            }
        }

        public string Info
        {
            get
            {
                return "Введи путь к папке, или нажми <Enter> для использования текущей папки: ";
            }
        }

        public IList Execute(Core.UserForm form, string pivot)
        {
            if (pivot == string.Empty)
            {
                string[] dis = Directory.GetFileSystemEntries(form.CurrentPath);
                return dis;
            }
            else
            {
                PathChecker.Check(pivot);
                string[] dis = Directory.GetFileSystemEntries(pivot);
                form.CurrentPath = pivot;
                return dis;
            }
        }

    }
}
