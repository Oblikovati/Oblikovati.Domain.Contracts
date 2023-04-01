﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D;

public interface IProjectToSurfaceCurve
{
    IAttributeSets AttributeSets { get; }
    IObjectCollection Faces { get; set; }
    IObjectCollection Curves { get; set; }
    ProjectCurveToSurfaceTypeEnum ProjectionType { get; set; }
    object ProjectDirection { get; set; }
    string Name { get; set; }
    ISketch3D Parent { get; }
    ISketchEntities3DEnumerator SketchEntities { get; }
    void BreakLink();
    void Delete();

    IProjectToSurfaceCurve Edit(IObjectCollection Faces, IObjectCollection Curves, object ProjectionType,
        object ProjectDirection);

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}