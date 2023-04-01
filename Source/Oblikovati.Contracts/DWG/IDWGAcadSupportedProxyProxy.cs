namespace Oblikovati.Contracts.DWG;

public interface IDWGAcadSupportedProxyProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
}