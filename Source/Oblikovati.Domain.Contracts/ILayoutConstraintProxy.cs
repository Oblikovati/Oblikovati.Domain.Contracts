using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILayoutConstraintProxy
{

    IAssemblyComponentDefinition Parent { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    IFlushConstraint XYFlushConstraint { get; }
    IFlushConstraint XZFlushConstraint { get; }
    IFlushConstraint YZFlushConstraint { get; }
    IAngleConstraint ZAngleConstraint { get; }
    ILayoutConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
