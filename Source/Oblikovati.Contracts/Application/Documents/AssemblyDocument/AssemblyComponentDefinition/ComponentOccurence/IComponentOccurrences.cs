﻿using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

public interface IComponentOccurrences : IList<IComponentOccurrences>
{
    IComponentOccurrence Item { get; }

    IComponentOccurrence ItemByName(string name);
    IComponentOccurrencesEnumerator AllLeafOccurrences { get; }
    IComponentOccurrencesEnumerator AllReferencedOccurrences { get; }

    IComponentOccurrence Add(string FullDocumentName, IMatrix Position);
    IComponentOccurrence AddByComponentDefinition(IComponentDefinition CompDef, IMatrix Position);
    IComponentOccurrence AddiPartMember(string FactoryFileName, IMatrix Position, object Row);

    IComponentOccurrence AddCustomiPartMember(string FactoryFileName, IMatrix Position, string FullFileName, object Row,
        object CustomInput);

    IComponentOccurrence _AddUsingiMates(string FullDocumentName, IMatrix Position);
    IComponentOccurrencesEnumerator AddUsingiMates(string FullDocumentName, bool PlaceAllMatching, object Options);
    IComponentOccurrence AddVirtual(string Name, IMatrix Position);
    IComponentOccurrence AddWithOptions(string FullDocumentName, IMatrix Position, INameValueMap Options);
    IComponentOccurrence AddiAssemblyMember(string FactoryDocumentName, IMatrix Position, object Row, object Options);
}