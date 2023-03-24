using FileTool;

namespace FileToolTests;

[TestClass]
public class FileToolTests
{
    private FileTool.FileTool _sut; // TODO fix namespace issue?  Should just be FileTool
    private DirectoryWrapper _directoryWrapper;
    private PathWrapper _pathWrapper;
    private FileWrapper _fileWrapper;
    
    [TestInitialize]
    public void Setup()
    {
        _directoryWrapper = new DirectoryWrapper();
        _pathWrapper = new PathWrapper();
        _fileWrapper = new FileWrapper();
        _sut = new global::FileTool.FileTool(_directoryWrapper, _pathWrapper, _fileWrapper);
    }
    
    [TestMethod]
    [Ignore]
    public void INTEGRATION_it_should_return_myFileInfos()
    {
        const string directory = @"C:\_Temp";

        var results = _sut.GetFileInfos(directory);
        
        Assert.AreEqual(2, results.Count);
        var firstFile = results.First();
        Assert.AreEqual(true , firstFile.Exists);
        Assert.AreEqual(".xlsx" , firstFile.Extension);
        Assert.AreEqual(14415 , firstFile.Length);
        Assert.AreEqual("2022-2023 Bowling Schedule.xlsx" , firstFile.Name);
        Assert.AreEqual(@"C:\_Temp" , firstFile.DirectoryName);
        Assert.AreEqual(false , firstFile.IsReadOnly);
        Assert.AreEqual(@"C:\_Temp\2022-2023 Bowling Schedule.xlsx", firstFile.FullName);
    }
}