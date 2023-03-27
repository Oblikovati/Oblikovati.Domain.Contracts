﻿namespace Oblikovati.Domain.Contracts;

public interface IWeld
{

    string Name { get; set; }
    IPoint SymbolAttachPoint { get; }
    IPoint SymbolBreakPoint { get; }
    string WeldInfo { get; }
    IAttributeSets AttributeSets { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
