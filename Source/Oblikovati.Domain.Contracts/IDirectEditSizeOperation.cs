﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDirectEditSizeOperation
{

    IFaces Faces { get; }
    string Name { get; }
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    IDirectEditFeature Parent { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}