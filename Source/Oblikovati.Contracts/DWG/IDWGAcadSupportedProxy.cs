namespace Oblikovati.Contracts.DWG;

public interface IDWGAcadSupportedProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
}