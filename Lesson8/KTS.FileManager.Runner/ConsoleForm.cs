using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data
{
    internal class ConsoleForm : IUserForm
    {
        public void MakeInfluence(IFileInfluence fileInfluence)
        {
            throw new NotImplementedException();
        }

        public string Show(int width, int height)
        {
            Console.SetWindowSize(width, height);
            Console.WriteLine(new string('\u2550', width));
            Console.ForegroundColor = ConsoleColor.Red;
            ColorWrite("Список доступных функций:");
            Console.WriteLine();
            ColorWrite("Содержимое папки", "Dir");
            ColorWrite("Создать папку/файл", "CrI");
            ColorWrite("Удалить папку/файл", "DlI");
            ColorWrite("Копировать папку/файл", "CpI");
            Console.WriteLine();
            ColorWrite("Перенести папку/файл", "RmI");
            ColorWrite("Переименовать папку/файл", "RnI");
            ColorWrite("Узнать информацию о папке/файле", "InI");
            ColorWrite("Поиск по маске файлов", "FbM");
            Console.WriteLine();
            ColorWrite("Получить статические данные текстового файла", "SdI");
            ColorWrite("Выход", "Ext");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(new string('\u2550', width));
            ColorWrite("Введи команду: ");
            return Console.ReadLine();
        }

        public void ShowInfo(IFileInfo fileInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Окраска текста
        /// </summary>
        private void ColorWrite(string discr)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{discr}");
            Console.ResetColor();
        }

        /// <summary>
        /// Окраска обозначения команды, вывод описания
        /// </summary>
        private void ColorWrite(string discr, string comm)
        {
            Console.ResetColor();
            Console.Write($"{discr}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{comm}");
            Console.ResetColor();
            Console.Write("; ");
        }
    }
}
