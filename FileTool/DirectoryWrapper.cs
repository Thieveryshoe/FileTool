namespace FileTool;

public interface IDirectoryWrapper
{
    void CreateDirectory(string path);
    bool Exists(string path);
    FileInfo[] GetFiles(string directory);
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

    public FileInfo[] GetFiles(string directory)
    {
        var di = new DirectoryInfo(directory);
        return di.GetFiles();
    }
}