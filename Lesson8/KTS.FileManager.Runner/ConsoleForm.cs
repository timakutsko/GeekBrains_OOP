using System;
using System.Collections;
using KTS.FileManager.Core;
using KTS.FileManager.Data;

namespace KTS.FileManager.Runner
{
    internal sealed class ConsoleForm : UserForm
    {

        public override string CurrentPath
        {
            get
            {
                return _currentPath;
            }
            set
            {
                string checkedPath = PathChecker.Check(value);
                _currentPath = checkedPath;
            }
        }

        public override void ShowWindow(int width, int height)
        {
            Width = width;
            Height = height;
            Console.SetWindowSize(Width, Height);
            ColorWrite("Для завершения работы с программой - нажми", "<Ctrl+C>");
            Console.WriteLine();
            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
            ColorWrite("Введи корневую папку: ");
            CurrentPath = Console.ReadLine();
            Console.Clear();
            Console.CancelKeyPress -= new ConsoleCancelEventHandler(myHandler);
        }

        public override string ShowWindowMenu()
        {
            Console.Clear();
            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
            ColorWrite("Текущая папка: ", $"{CurrentPath}");
            Console.WriteLine();
            ColorWrite("Для завершения работы с программой - нажми", "<Ctrl+C>");
            Console.WriteLine();
            Console.WriteLine(new string('\u2550', Width));
            Console.ForegroundColor = ConsoleColor.Red;
            ColorWrite("Список доступных функций:");
            Console.WriteLine();
            ColorWrite("Показать содержимое папки, и перейти в неё", "Dir; ");
            ColorWrite("Создать папку/файл", "CrI; ");
            ColorWrite("Удалить папку/файл", "DlI; ");
            ColorWrite("Копировать папку/файл", "CpI; ");
            Console.WriteLine();
            ColorWrite("Перенести папку/файл", "RmI; ");
            ColorWrite("Поиск по маске файлов", "FbM. ");
            Console.WriteLine();
            Console.WriteLine(new string('\u2550', Width));
            ColorWrite("Введи команду: ");
            return Console.ReadLine();
        }

        public override string ShowInfo(IUserCommand command)
        {
            ColorWrite(command.Info);
            return Console.ReadLine();
        }

        public override void ShowResult(IEnumerable results)
        {
            Console.Clear();
            foreach (string result in results)
            {
                ColorWrite(result);
                Console.WriteLine();
            }
            Console.WriteLine("Нажми <Enter>, чтобы продолжить.");
            Console.ReadLine();
            Console.Clear();
        }

        public override void ShowError(string str)
        {
            ColorWrite(str);
            Console.WriteLine();
            Console.WriteLine("Нажми <Enter>, чтобы повторить ввод.");
            Console.ReadLine();
        }

        public override string ShowEvantMessage(string str)
        {
            ColorWrite(str);
            ConsoleKeyInfo userKey = Console.ReadKey();
            return userKey.Key.ToString();
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
        }

        private void myHandler(object sender, ConsoleCancelEventArgs args)
        {
            {
                if (args.SpecialKey == ConsoleSpecialKey.ControlC)
                {
                    ColorWrite("ЗАВЕРШЕНО!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
