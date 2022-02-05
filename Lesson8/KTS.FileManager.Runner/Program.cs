using System;
using System.Collections;
using KTS.FileManager.Core;
using KTS.FileManager.Data;

namespace KTS.FileManager.Runner
{
    
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            
            // Создание репозитория команд
            CommandsRepository commandsRepository = new CommandsRepository();
            
            // Создание пользовательского окна
            ConsoleForm form = new ConsoleForm();
            form.IsVisible = true;
            while (form.IsVisible)
            {
                try
                {
                    form.ShowWindow(200, 50);
                    form.IsVisible = false;
                }
                catch (UserException usEx) when (!usEx.Message.ToUpper().Contains("EXT"))
                {
                    form.ShowError(usEx.Message);
                }
            }
            
            // Создание пользовательского меню
            form.IsVisible = true;
            while (form.IsVisible)
            {
                try
                {
                    string input = form.ShowWindowMenu();
                    bool notWorked = true;
                    foreach (IUserCommand command in commandsRepository.Commands)
                    {
                        if (command.Name == input.ToUpper())
                        {
                            string secondInput = form.ShowInfo(command);
                            IList result = command.Execute(form, secondInput);
                            form.ShowResult(result);
                            notWorked = false;
                            break;
                        }
                    }
                    if(notWorked)
                    {
                        form.ShowError("Такой команды нет");
                    }
                }
                catch (UserException usEx)
                {
                    form.ShowError(usEx.Message);
                }
                catch (Exception ex)
                {
                    if(Environment.ExitCode != 0)
                    {
                        form.ShowError(ex.Message);
                    }
                }
            }
        }
    }
}
