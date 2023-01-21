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
    private readonly IPathWrapper _pathWrapper;
    private readonly IFileWrapper _fileWrapper;

    public FileTool(IDirectoryWrapper directoryWrapper, IPathWrapper pathWrapper, IFileWrapper fileWrapper)
    {
        _directoryWrapper = directoryWrapper;
        _pathWrapper = pathWrapper;
        _fileWrapper = fileWrapper;
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
        var fileInfoWrappers = filesInfos.Select(x => new FileInfoWrapper(x.DirectoryName)).ToList();
        return fileInfoWrappers.Select(x => new MyFileInfo
        {
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
        _fileWrapper.Move(file, targetDirectory);
    }
}