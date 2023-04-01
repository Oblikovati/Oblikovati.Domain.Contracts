using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts;

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