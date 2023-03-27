using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRectangularOccurrencePatternProxy
{

    IAssemblyComponentDefinition Parent { get; }
    string Name { get; set; }
    bool Visible { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IOccurrencePatternElements OccurrencePatternElements { get; }
    IObjectCollection ParentComponents { get; set; }
    IAttributeSets AttributeSets { get; }
    bool IsPatternElement { get; }
    IOccurrencePatternElement PatternElement { get; }
    OccurrencePatternSuppressionEnum Suppressed { get; }
    IParameter ColumnCount { get; }
    object ColumnEntity { get; set; }
    bool ColumnEntityNaturalDirection { get; set; }
    IParameter ColumnOffset { get; }
    IOccurrencePatternElement OccurrencePatternElement { get; }
    IParameter RowCount { get; }
    object RowEntity { get; set; }
    bool RowEntityNaturalDirection { get; set; }
    IParameter RowOffset { get; }
    IRectangularOccurrencePattern NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Suppress(bool SkipDocumentSave);
    void Unsuppress();
}
