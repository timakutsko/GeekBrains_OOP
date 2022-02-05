using System.IO;

namespace KTS.FileManager.Data
{
    public static class PathChecker
    {
        public static string Check(string path)
        {
            if (Directory.Exists(path) || File.Exists(path))
            {
                return path;
            }
            else
            {
                throw new UserException("Ошибка ввода", $"{path} - это не путь к папке, или файлу");
            }
        }
    }
}
