﻿using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.GeometricConstraints;

public interface ICollinearConstraintProxy
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    bool UseEllipseOneMajorAxis { get; }
    bool UseEllipseTwoMajorAxis { get; }
    ICollinearConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}