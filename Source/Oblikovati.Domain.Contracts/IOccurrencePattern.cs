using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOccurrencePattern
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
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Suppress(bool SkipDocumentSave);
    void Unsuppress();
}
