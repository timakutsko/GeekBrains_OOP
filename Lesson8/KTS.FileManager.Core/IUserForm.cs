namespace KTS.FileManager.Core
{
    public interface IUserForm
    {
        public string Show(int width, int height);

        public void ShowInfo(IFileInfo fileInfo);

        public void MakeInfluence(IFileInfluence fileInfluence);
    }
}
