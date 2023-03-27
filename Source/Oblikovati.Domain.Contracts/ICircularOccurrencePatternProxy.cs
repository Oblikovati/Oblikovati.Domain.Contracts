using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICircularOccurrencePatternProxy
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
    IParameter AngleOffset { get; }
    object AxisEntity { get; set; }
    bool AxisEntityNaturalDirection { get; set; }
    IParameter ElementCount { get; }
    bool LockRotation { get; set; }
    object PatternRadiusPoint { get; set; }
    ICircularOccurrencePattern NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Suppress(bool SkipDocumentSave);
    void Unsuppress();
}
