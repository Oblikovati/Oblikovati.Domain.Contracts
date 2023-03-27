namespace Oblikovati.Domain.Contracts;

public interface IDWGEllipticalArc
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Center { get; }
    IUnitVector Normal { get; }
}
