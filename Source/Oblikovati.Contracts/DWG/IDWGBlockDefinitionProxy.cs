﻿using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGBlockDefinitionProxy
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
    IDWGBlockDefinition NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}