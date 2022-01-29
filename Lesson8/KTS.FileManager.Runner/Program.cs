using System;
using System.Collections.Generic;
using KTS.FileManager.Core;
using KTS.FileManager.Data;
using KTS.FileManager.Data.Commands;

namespace KTS.FileManager.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyCollection<IUserCommand> userCommads = new List<IUserCommand>() 
            { 
                new Create(), 
                new Remove() 
            };
            CommandsRepository commandsRepository = new CommandsRepository(userCommads);
            var a = commandsRepository.GetByType(Command.Create);

            ConsoleForm form = new ConsoleForm();
            
            while (true)
            {
                string input = form.Show(200, 50);
            }

        }
    }
}
