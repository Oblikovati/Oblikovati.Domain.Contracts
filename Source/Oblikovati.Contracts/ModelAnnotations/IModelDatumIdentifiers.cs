using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDatumIdentifiers : IList<IModelDatumIdentifiers>
{
    IModelDatumIdentifier Item { get; }
    string NextAvailableDatumText { get; }
    string ExcludedDatumTextCharacters { get; }

    IModelDatumIdentifier Add(IModelDatumIdentifierDefinition Definition);

    IModelDatumIdentifierDefinition CreateDefinition(IGeometryIntent Intent,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition);
}