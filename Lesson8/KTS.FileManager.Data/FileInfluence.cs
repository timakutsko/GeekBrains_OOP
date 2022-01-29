using System;
using System.IO;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data
{
    public class FileInfluence : IFileInfluence
    {
        public void CopyItem(string pathFrom, string pathTo)
        {
            throw new NotImplementedException();
        }

        public void CreateItem(string path, string extension)
        {
            string fullPath = Path.Combine(path, ".", extension);
            File.Create(fullPath);
        }

        public void DeleteItem(string path)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(string pathFrom, string pathTo)
        {
            throw new NotImplementedException();
        }

        public void RenameItem(string path)
        {
            throw new NotImplementedException();
        }
    }
}
