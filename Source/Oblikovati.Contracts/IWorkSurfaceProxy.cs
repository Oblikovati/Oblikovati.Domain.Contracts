﻿using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts;

public interface IWorkSurfaceProxy
{
    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    ISurfaceBody _SurfaceBody { get; }
    IWorkSurface ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Translucent { get; set; }
    bool Visible { get; set; }
    bool Suppressed { get; }
    ISurfaceBodies SurfaceBodies { get; }
    bool Exported { get; set; }
    IWorkSurface NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}