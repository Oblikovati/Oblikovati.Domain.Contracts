using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;

public interface IBOMRow
{
    IAttributeSets AttributeSets { get; }
    bool Merged { get; }
    bool Promoted { get; }
    bool RolledUp { get; }
    IComponentDefinitionsEnumerator ComponentDefinitions { get; }
    BOMStructureEnum BOMStructure { get; set; }
    string ItemNumber { get; set; }
    int ItemQuantity { get; }
    string TotalQuantity { get; set; }
    bool TotalQuantityOverridden { get; set; }
    IBOMRowsEnumerator ChildRows { get; }
    bool ItemNumberLocked { get; set; }
    IPropertySets OccurrencePropertySets { get; }
    IComponentOccurrencesEnumerator ComponentOccurrences { get; }
    IFileDescriptor ReferencedFileDescriptor { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}