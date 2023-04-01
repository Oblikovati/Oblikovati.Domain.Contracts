using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D.DimensionConstraints;

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