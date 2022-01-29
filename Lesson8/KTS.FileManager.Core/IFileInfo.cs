using System.Collections.Generic;

namespace KTS.FileManager.Core
{
    public interface IFileInfo
    {
        public IReadOnlyList<string> ShowItems(string path);

        public int ShowItemSize(string path);
        
        public IReadOnlyList<string> ShowStaticData(string path);
        
        public IReadOnlyList<string> ShowMaskItems(string path, string mask);
    }
}
