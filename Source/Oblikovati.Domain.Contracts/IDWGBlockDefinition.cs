namespace Oblikovati.Domain.Contracts;

public interface IDWGBlockDefinition
{

    IDWGArcsEnumerator Arcs { get; }
    IDWGBlockReferencesEnumerator BlockReferences { get; }
    IDWGEllipticalArcsEnumerator EllipticalArcs { get; }
    IDWGEntitiesEnumerator Entities { get; }
    bool IsModelSpaceDefinition { get; }
    IDWGLinesEnumerator Lines { get; }
    IImportedDWGComponent Parent { get; }
    IDWGPointsEnumerator Points { get; }
    IDWGPolylinesEnumerator Polylines { get; }
    IDWGPolylines2DEnumerator Polylines2D { get; }
    IDWGPolylines3DEnumerator Polylines3D { get; }
    IDWGSplinesEnumerator Splines { get; }
    IDWGACMStandardPartsEnumerator ACMStandardParts { get; }
    IDWGAcadSupportedProxiesEnumerator AcadSupportedProxies { get; }
}
