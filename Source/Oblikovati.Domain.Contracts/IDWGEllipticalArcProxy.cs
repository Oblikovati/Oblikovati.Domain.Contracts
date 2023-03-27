namespace Oblikovati.Domain.Contracts;

public interface IDWGEllipticalArcProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Center { get; }
    IUnitVector Normal { get; }
    IDWGEllipticalArc NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
