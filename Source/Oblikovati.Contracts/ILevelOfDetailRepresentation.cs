using Oblikovati.Contracts.Application.Documents;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ILevelOfDetailRepresentation
{
    IRepresentationsManager Parent { get; }
    string Name { get; set; }
    LevelOfDetailEnum LevelOfDetail { get; }
    IAttributeSets AttributeSets { get; }
    IComponentOccurrence SubstituteOccurrence { get; }
    IDocumentDescriptor SubstituteDocumentDescriptor { get; }
    IModelState _MigrateToModelState { get; }
    IComponentOccurrencesEnumerator _ComponentsForLegacySysLOD { get; }
    bool _IsRetiredLOD { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate(bool SkipDocumentSave);
    ILevelOfDetailRepresentation Copy(string NewName);
    void Delete();
}