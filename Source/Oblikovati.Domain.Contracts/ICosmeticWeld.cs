namespace Oblikovati.Domain.Contracts;

public interface ICosmeticWeld
{

    string Name { get; set; }
    IPoint SymbolAttachPoint { get; }
    IPoint SymbolBreakPoint { get; }
    string WeldInfo { get; }
    IAttributeSets AttributeSets { get; }
    IEdges Edges { get; }
    ICosmeticWeldDefinition Definition { get; set; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
