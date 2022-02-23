using System.Collections;

namespace KTS.FileManager.Core
{
    public enum Command
    {
        Exit = 0,
        Dir = 1,
        Create = 2,
        Delete = 3,
        Rename = 4,
        Copy = 5,
        Remove = 6,
        Size = 7,
        FindByMask = 8,
        StaticData = 9,
    }

    public interface IUserCommand
    {
        public string Info { get; }
        public int Type { get; }
        public string Name { get; }
        public IList Execute(UserForm form, string pivot);
    }
}
