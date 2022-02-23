using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace KTS.FileManager.Data.Commands
{
    internal class CopyRemoveExecute
    {
        private string _currentCommand;
        
        public IList Execute(Core.UserForm form, string pivot)
        {
            List<string> result = new List<string>();
            string[] items = pivot.Split('~');
            string fullPathFrom = Path.Combine(form.CurrentPath, items[0]);
            string fullPathTo = Path.Combine(items[1], items[0]);
            string extensionFrom = Path.GetExtension(items[0]);
            string extensionTo = Path.GetExtension(items[1]);
            if (extensionTo == string.Empty)
            {
                try
                {
                    if (GetType() == typeof(CommandRemove))
                    {

                        _currentCommand = "Перенести";
                        if (extensionFrom != string.Empty)
                        {
                            File.Move(fullPathFrom, fullPathTo);
                        }
                        else
                        {
                            Directory.Move(fullPathFrom, fullPathTo);
                        }
                    }
                    else if (GetType() == typeof(CommandCopy))
                    {
                        _currentCommand = "Копировать";
                        if (extensionFrom != string.Empty)
                        {
                            File.Copy(fullPathFrom, fullPathTo);
                        }
                        else
                        {
                            Directory.CreateDirectory(fullPathTo);
                            CopyFilesRecursively(new DirectoryInfo(fullPathFrom), new DirectoryInfo(fullPathTo));
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    throw new UserException("Ошибка переноса/копирования", "Такого файла нет!");
                }
                catch (DirectoryNotFoundException)
                {
                    throw new UserException("Ошибка переноса/копирования", "Такой папки нет!");
                }
                catch (IOException)
                {
                    throw new UserException("Ошибка переноса/копирования", "Либо такой элемент уже существует, либо указанного пути нет");
                }
                catch
                {
                    throw new UserException("Ошибка переноса/копирования", "Что-то пошло не так. Внимательно вводи путь, имя файла и не забывай про тильду ~");
                }

            }
            else
            {
                throw new UserException("Ошибка переноса/копирования", "Нельзя переносить/копировать элемент в файл!");
            }
            result.Add(string.Concat($"Элементу подвергся команде {_currentCommand}! Новый полный путь: {fullPathTo}"));
            return result;
        }
        
        private static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in source.GetFiles())
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name));
            }
        }
    }
}
