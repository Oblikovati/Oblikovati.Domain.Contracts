﻿using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IFaceShellProxy
{
    ISurfaceBody Parent { get; }
    IFaces Faces { get; }
    IEdges Edges { get; }
    ISurfaceBody SurfaceBody { get; }
    bool IsClosed { get; }
    bool IsVoid { get; }
    ContainmentEnum IsPointInside { get; }
    IBox RangeBox { get; }
    double Volume { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    IFaceShell NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}