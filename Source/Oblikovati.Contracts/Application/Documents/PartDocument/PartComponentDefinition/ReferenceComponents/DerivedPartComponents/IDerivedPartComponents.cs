using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartComponents : IList<IDerivedPartComponents>
{
    IDerivedPartComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedPartComponent Add(IDerivedPartDefinition Definition);
    IDerivedPartUniformScaleDef CreateDefinition(string FullDocumentName);
    IDerivedPartUniformScaleDef CreateUniformScaleDef(string FullFileName);
    IDerivedPartTransformDef CreateTransformDef(string FullFileName);
    IDerivedPartCoordinateSystemDef CreateCoordinateSystemDef(string FullFileName);
    IDerivedPartUniformScaleDef _CreateUniformScaleDef(string FullFileName);
    IDerivedPartTransformDef _CreateTransformDef(string FullFileName);
    IDerivedPartCoordinateSystemDef _CreateCoordinateSystemDef(string FullFileName);
}