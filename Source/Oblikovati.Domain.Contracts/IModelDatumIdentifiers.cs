namespace Oblikovati.Domain.Contracts;

public interface IModelDatumIdentifiers : IList<IModelDatumIdentifiers>
{
    int Count { get; }
    IModelDatumIdentifier Item { get; }
    string NextAvailableDatumText { get; }
    string ExcludedDatumTextCharacters { get; }
    IEnumerator GetEnumerator();
    IModelDatumIdentifier Add(IModelDatumIdentifierDefinition Definition);
    IModelDatumIdentifierDefinition CreateDefinition(IGeometryIntent Intent, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition);
}
