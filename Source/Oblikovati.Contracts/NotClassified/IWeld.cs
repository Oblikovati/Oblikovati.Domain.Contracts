using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.NotClassified;

public interface IWeld
{
    string Name { get; set; }
    IPoint SymbolAttachPoint { get; }
    IPoint SymbolBreakPoint { get; }
    string WeldInfo { get; }
    IAttributeSets AttributeSets { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}