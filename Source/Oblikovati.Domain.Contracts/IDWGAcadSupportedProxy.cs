namespace Oblikovati.Domain.Contracts;

public interface IDWGAcadSupportedProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
}
