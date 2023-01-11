namespace FileTool;

public interface IFileTool
{
    void CreateDirectory(string directory);
    bool DirectoryExists(string directory);
    List<MyFileInfo> GetFileInfos(string directory);
    void MoveFile(string file, string targetDirectory);
}

public class FileTool : IFileTool
{
    private readonly IDirectoryWrapper _directoryWrapper;
    private readonly IDirectoryInfoWrapper _directoryInfoWrapper;

    public FileTool(IDirectoryWrapper directoryWrapper, IDirectoryInfoWrapper directoryInfoWrapper)
    {
        _directoryWrapper = directoryWrapper;
        _directoryInfoWrapper = directoryInfoWrapper;
    }

    public void CreateDirectory(string directory)
    {
        _directoryWrapper.CreateDirectory(directory);
    }

    public bool DirectoryExists(string directory)
    {
        return _directoryWrapper.Exists(directory);
    }

    public List<MyFileInfo> GetFileInfos(string directory)
    {
        throw new NotImplementedException();
    }

    public void MoveFile(string file, string targetDirectory)
    {
        throw new NotImplementedException();
    }
}