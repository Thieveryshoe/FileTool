using FileTool;
using FileTool = FileTool.FileTool;

namespace FileToolTests;

[TestClass]
public class FileToolTests
{
    // TODO fix namespace issue?  Should just be FileTool
    private global::FileTool.FileTool _sut;
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
        
        Assert.AreEqual(1, results.Count);
    }
}