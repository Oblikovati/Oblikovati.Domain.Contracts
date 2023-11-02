using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.DirectEditFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IDirectEditScaleOperation
{
    IFaces Faces { get; }
    string Name { get; }
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    IDirectEditFeature Parent { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}