using System.IO;

namespace KTS.FileManager.Core
{
    public interface IFileInfluence
    {
        public void CreateItem(string path, string extension);
        
        public void DeleteItem(string path);

        public void RenameItem(string path);

        public void CopyItem(string pathFrom, string pathTo);

        public void RemoveItem(string pathFrom, string pathTo);
    }
}
