using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
