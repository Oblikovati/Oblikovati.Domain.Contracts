namespace Oblikovati.Domain.Contracts;

public interface IModelDatumReferenceFrames : IList<IModelDatumReferenceFrames>
{
    int Count { get; }
    IModelDatumReferenceFrame Item { get; }
    IEnumerator GetEnumerator();
    IModelDatumReferenceFrame Add(IModelDatumReferenceFrameDefinition Definition, object ClientId);
    IModelDatumReferenceFrameDefinition CreateDefinition(IMatrix CoordinateSystem, IModelToleranceFeature PrimaryDatum, object SecondaryDatum, object TertiaryDatum);
}
