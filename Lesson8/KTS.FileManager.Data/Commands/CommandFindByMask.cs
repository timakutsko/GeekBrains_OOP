using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTS.FileManager.Data.Commands
{
    sealed class CommandFindByMask : Core.IUserCommand
    {
        public int Type
        {
            get
            {
                return (int)Core.Command.FindByMask;
            }
        }

        public string Name
        {
            get
            {
                return "FBM";
            }
        }

        public string Info
        {
            get
            {
                return "Находит вхождение файлов по расширению в папки и подпапки. Введи расширение, в формате <txt>, без лишних символов: ";
            }
        }

        public IList Execute(Core.UserForm form, string pivot)
        {
            string path = form.CurrentPath;
            List<string> dis = Directory.GetFiles(path).ToList();
            List<string> result = new List<string>();
            string fileExtension = String.Concat('.', pivot);
            FindItemsRecursively(new DirectoryInfo(path), result, fileExtension);
            if(result.Count > 0)
            {
                return result;
            }
            else
            {
                result.Add($"Файлов с расширением {pivot} в папке {path} и всех её подпапках - нет");
                return result;
            }
        }

        private static void FindItemsRecursively(DirectoryInfo source, IList list, string trueExtension)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                FindItemsRecursively(dir, list, trueExtension);
            }
            foreach (FileInfo file in source.GetFiles())
            {
                string extension = file.Extension;
                if (extension == trueExtension)
                {
                    list.Add(file.FullName);
                }
            }
        }
    }
}
