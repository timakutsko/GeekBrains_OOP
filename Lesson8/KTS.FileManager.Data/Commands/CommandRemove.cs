namespace KTS.FileManager.Data.Commands
{
    public class CommandRemove : CopyRemoveExecute, Core.IUserCommand
    {
        public int Type
        {
            get
            {
                return (int)Core.Command.Remove;
            }
        }

        public string Name
        {
            get
            {
                return "RMI";
            }
        }

        public string Info
        {
            get
            {
                return "Введи имя элемента из текущей папки, который нужно перенести. Через тильду ~ введи путь для перемещения: ";
            }
        }
    }
}
