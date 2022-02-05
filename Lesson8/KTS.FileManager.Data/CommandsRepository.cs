using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;
using KTS.FileManager.Data.Commands;

namespace KTS.FileManager.Data
{
    public sealed class CommandsRepository
    {
        private readonly IReadOnlyDictionary<int, IUserCommand> _index;
        public readonly IReadOnlyCollection<IUserCommand> Commands = new List<IUserCommand>()
        {
            new CommandCreate(),
            new CommandDirectory(),
            new CommandCopy(),
            new CommandDelete(),
            new CommandFindByMask(),
            new CommandRemove()
        };

        public CommandsRepository()
        {
            _index = Commands.ToDictionary(c => c.Type, c => c) ;
        }
        private IUserCommand GetByType(int type)
        {
            if(_index.TryGetValue(type, out IUserCommand command))
            {
                return command;
            }
            else 
            { 
                return null; 
            }
        }

        public IUserCommand GetByType(Command command)
        {
            return GetByType((int)command);
        }

    }
}
