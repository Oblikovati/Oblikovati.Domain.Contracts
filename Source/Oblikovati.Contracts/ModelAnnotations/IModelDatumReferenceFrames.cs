using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDatumReferenceFrames : IList<IModelDatumReferenceFrames>
{
    IModelDatumReferenceFrame Item { get; }

    IModelDatumReferenceFrame Add(IModelDatumReferenceFrameDefinition Definition, object ClientId);

    IModelDatumReferenceFrameDefinition CreateDefinition(IMatrix CoordinateSystem, IModelToleranceFeature PrimaryDatum,
        object SecondaryDatum, object TertiaryDatum);
}