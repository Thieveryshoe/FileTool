namespace FileTool;

public class MyFileInfo
{
    public string DirectoryName { get; set; }
    public bool Exists { get; set; }
    public string Extension { get; set; }
    public bool IsReadOnly { get; set; }
    public long Length { get; set; }
    public string Name { get; set; }
}