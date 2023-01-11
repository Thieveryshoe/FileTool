namespace FileTool;

public interface IDirectoryWrapper
{
    void CreateDirectory(string path);
    bool Exists(string path);
}

public class DirectoryWrapper : IDirectoryWrapper
{
    public void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }

    public bool Exists(string path)
    {
        return Directory.Exists(path);
    }
}