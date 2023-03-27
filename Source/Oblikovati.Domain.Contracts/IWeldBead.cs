namespace Oblikovati.Domain.Contracts;

public interface IWeldBead
{

    string Name { get; set; }
    IPoint SymbolAttachPoint { get; }
    IPoint SymbolBreakPoint { get; }
    string WeldInfo { get; }
    IAttributeSets AttributeSets { get; }
    IFaces BeadFaces { get; }
    double BeadLength { get; }
    IFaces EndFaces { get; }
    IFaces SideFaces { get; }
    IFaces FaceSetOne { get; }
    IFaces FaceSetTwo { get; }
    bool _IsLegacyWeldBead { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
