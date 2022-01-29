using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data
{
    public sealed class CommandsRepository
    {
        private readonly IReadOnlyDictionary<int, IUserCommand> _index;

        public CommandsRepository(IReadOnlyCollection<IUserCommand> command)
        {
            _index = command.ToDictionary(c => c.Type, c => c) ;
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
