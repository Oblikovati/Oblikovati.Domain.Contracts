using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDirectEditMoveOperationProxy
{

    IFaces Faces { get; }
    string Name { get; }
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    IDirectEditFeature Parent { get; }
    IDirectEditMoveOperation NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
