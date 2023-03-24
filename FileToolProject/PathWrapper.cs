namespace FileTool;

public interface IPathWrapper
{
    string GetExtension(string path);
}

public class PathWrapper : IPathWrapper
{
    public string GetExtension(string path)
    {
        return Path.GetExtension(path);
    }
}