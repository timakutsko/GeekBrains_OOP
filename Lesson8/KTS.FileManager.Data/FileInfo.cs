using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTS.FileManager.Core;

namespace KTS.FileManager.Data
{
    public class FileInfo : IFileInfo
    {
        public IReadOnlyList<string> ShowItems(string path)
        {
            throw new NotImplementedException();
        }

        public int ShowItemSize(string path)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<string> ShowMaskItems(string path, string mask)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<string> ShowStaticData(string path)
        {
            throw new NotImplementedException();
        }
    }
}
