namespace KTS.FileManager.Data.Commands
{
    sealed class CommandCopy : CopyRemoveExecute, Core.IUserCommand
    {
        public int Type
        {
            get
            {
                return (int)Core.Command.Copy;
            }
        }

        public string Name
        {
            get
            {
                return "CPI";
            }
        }

        public string Info
        {
            get
            {
                return "Введи имя элемента из текущей папки, который нужно скопировать. Через тильду ~ введи путь для копирования: ";
            }
        }
    }
}
