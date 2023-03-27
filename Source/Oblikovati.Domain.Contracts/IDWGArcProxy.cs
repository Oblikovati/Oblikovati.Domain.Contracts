namespace Oblikovati.Domain.Contracts;

public interface IDWGArcProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Center { get; }
    IUnitVector Normal { get; }
    IDWGArc NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
