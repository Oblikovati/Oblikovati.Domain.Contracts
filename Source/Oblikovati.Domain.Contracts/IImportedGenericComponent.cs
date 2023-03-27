﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IImportedGenericComponent
{

    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IImportedComponentDefinition Definition { get; set; }
    bool SuppressLinkToFile { get; set; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}