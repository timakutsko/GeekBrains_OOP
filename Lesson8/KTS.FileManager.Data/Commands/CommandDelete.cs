using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace KTS.FileManager.Data.Commands
{
    internal class CommandDelete : Core.IUserCommand
    {
        public int Type
        {
            get
            {
                return (int)Core.Command.Delete;
            }
        }

        public string Name
        {
            get
            {
                return "DLI";
            }
        }

        public string Info
        {
            get
            {
                return "Введи путь к элементу для удаления. Для удаления элемента в текущей папке - достаточно ввести имя. Для файла - укажи расширение: ";
            }
        }

        public IList Execute(Core.UserForm form, string pivot)
        {
            List<string> result = new List<string>();
            string fullPath;
            
            if (Directory.Exists(pivot) || File.Exists(pivot))
            {
                fullPath = pivot;
            }
            else
            {
                fullPath = Path.Combine(form.CurrentPath, pivot);
            }
            string extension = Path.GetExtension(fullPath);
            if (extension == string.Empty)
            {
                Directory.Delete(fullPath);
            }
            else
            {
                File.Delete(fullPath);
            }
            result.Add(string.Concat($"Элемент {fullPath} - удален!"));
            return result;
        }

    }
}
