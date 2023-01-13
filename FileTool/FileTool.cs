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
    private readonly IPathWrapper _pathWrapper;

    public FileTool(IDirectoryWrapper directoryWrapper, IDirectoryInfoWrapper directoryInfoWrapper, IPathWrapper pathWrapper)
    {
        _directoryWrapper = directoryWrapper;
        _directoryInfoWrapper = directoryInfoWrapper;
        _pathWrapper = pathWrapper;
        ;
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
        var filesInfos = _directoryWrapper.GetFiles(directory);
        var fileInfoWrappers = filesInfos.Select(x => new FileInfoWrapper(x.DirectoryName!)).ToList();
        return fileInfoWrappers.Select(x => new MyFileInfo
        {
            Directory = x.Directory,
            DirectoryName = x.DirectoryName,
            Exists = x.Exists,
            Extension = _pathWrapper.GetExtension(x.DirectoryName),
            IsReadOnly = x.IsReadOnly,
            Length = x.Length,
            Name = x.Name
        }).ToList();

    }

    public void MoveFile(string file, string targetDirectory)
    {
        throw new NotImplementedException();
    }
}