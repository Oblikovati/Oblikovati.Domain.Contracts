﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDerivedAliasComponent
{

    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IObjectsEnumerator ResultFeatures { get; }
    string ReferencedAliasFullFilename { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}