namespace Oblikovati.Contracts;

public interface ITestProgram
{
    string Name { get; }
    string Description { get; }
    string Path { get; }
    string Type { get; }
    void Run(object Test, ITestInputOutput TestIO, bool bDebug);
    void ActivatePane(bool bDebug);
}