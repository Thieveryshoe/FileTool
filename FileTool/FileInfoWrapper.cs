namespace FileTool;

public class FileInfoWrapper 
{
    private readonly FileInfo _wrapped;

    public FileInfoWrapper(FileInfo file)
    {
        _wrapped = file;
    }

    public FileInfoWrapper(string path)
    {
        _wrapped = new FileInfo(path);
    }

    public DirectoryInfo Directory => _wrapped.Directory;
    public string DirectoryName => _wrapped.DirectoryName;
    public bool Exists => _wrapped.Exists;
    public bool IsReadOnly => _wrapped.IsReadOnly;
    public long Length => _wrapped.Length;
    public string Name => _wrapped.Name;
}