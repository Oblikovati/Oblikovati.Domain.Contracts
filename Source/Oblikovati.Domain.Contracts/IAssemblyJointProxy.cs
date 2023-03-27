using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssemblyJointProxy
{
    IComponentOccurrence AffectedOccurrenceOne { get; }
    IComponentOccurrence AffectedOccurrenceTwo { get; }

    IAttributeSets AttributeSets { get; }
    IAssemblyJointDefinition Definition { get; set; }
    IDriveSettings DriveSettings { get; }
    HealthStatusEnum HealthStatus { get; }
    bool Locked { get; set; }
    string Name { get; set; }
    bool Protected { get; set; }
    IComponentOccurrence OccurrenceOne { get; }
    IComponentOccurrence OccurrenceTwo { get; }
    IAssemblyComponentDefinition Parent { get; }
    bool Visible { get; set; }
    bool Suppressed { get; set; }
    IAssemblyJoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
