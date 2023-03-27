namespace Oblikovati.Domain.Contracts;

public interface IDWGLine
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IUnitVector Direction { get; }
    IPoint EndPoint { get; }
    IPoint StartPoint { get; }
}
