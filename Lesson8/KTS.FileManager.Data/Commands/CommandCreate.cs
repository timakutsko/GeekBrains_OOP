using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace KTS.FileManager.Data.Commands
{
    sealed class CommandCreate : Core.IUserCommand
    {
        public int Type
        {
            get 
            { 
                return (int)Core.Command.Create; 
            }
        }

        public string Name
        {
            get
            {
                return "CRI";
            }
        }

        public string Info
        {
            get
            {
                return "Создает элемент в текущей папке. Для этого - введи имя папки, или файла. Для файла - укажи расширение: ";
            }
        }

        public IList Execute(Core.UserForm form, string pivot)
        {
            List<string> result = new List<string>();
            string fullPath = Path.Combine(form.CurrentPath, pivot);
            string extension = Path.GetExtension(fullPath);
            if (extension == string.Empty)
            {
                Directory.CreateDirectory(fullPath);
            }
            else
            {
                File.Create(fullPath);
            }
            result.Add(string.Concat($"Элемент создан! Путь: {fullPath}"));
            return result;
        }
    }
}
