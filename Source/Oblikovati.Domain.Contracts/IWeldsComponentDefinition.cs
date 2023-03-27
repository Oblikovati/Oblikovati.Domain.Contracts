using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWeldsComponentDefinition
{

    ISurfaceBodies SurfaceBodies { get; }
    IComponentOccurrences Occurrences { get; }
    object Document { get; }
    IDataIO DataIO { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    string ModelGeometryVersion { get; }
    IAttributeSets AttributeSets { get; }
    BOMStructureEnum BOMStructure { get; set; }
    IBOMQuantity BOMQuantity { get; }
    IBox RangeBox { get; }
    IComponentDefinitionReferences ImmediateReferencedDefinitions { get; }
    IObjectsEnumerator FindUsingPoint(IPoint Point, List<SelectionFilterEnum> ObjectTypes, object ProximityTolerance, bool VisibleObjectsOnly);
    void _InvalidateSketchNodes();
    IObjectsEnumerator FindUsingVector(IPoint OriginPoint, IUnitVector Direction, List<SelectionFilterEnum> ObjectTypes, bool UseCylinder, object ProximityTolerance, bool VisibleObjectsOnly, out object LocationPoints);
}
