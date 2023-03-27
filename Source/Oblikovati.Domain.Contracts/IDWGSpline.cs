namespace Oblikovati.Domain.Contracts;

public interface IDWGSpline
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
}
