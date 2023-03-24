namespace FileTool;

public interface IFileWrapper
{
    void Move(string file, string targetDirectory);
}

public class FileWrapper : IFileWrapper
{
    public void Move(string file, string targetDirectory)
    {
        File.Move(file, targetDirectory);
    }
}