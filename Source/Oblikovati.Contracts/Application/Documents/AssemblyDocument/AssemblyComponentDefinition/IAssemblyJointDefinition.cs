using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyJointDefinition
{
    AssemblyJointTypeEnum JointType { get; set; }
    IGeometryIntent OriginOne { get; set; }
    IGeometryIntent OriginTwo { get; set; }
    bool FlipOriginDirection { get; set; }
    bool FlipAlignmentDirection { get; set; }
    object Gap { get; set; }
    IAssemblyJoint Parent { get; }
    object LinearPosition { get; set; }
    bool HasLinearPositionEndLimit { get; set; }
    bool HasLinearPositionStartLimit { get; set; }
    object LinearPositionEndLimit { get; set; }
    object LinearPositionStartLimit { get; set; }
    object AngularPosition { get; set; }
    bool HasAngularPositionLimits { get; set; }
    object AngularPositionEndLimit { get; set; }
    object AngularPositionStartLimit { get; set; }
    object AlignmentOne { get; set; }
    object AlignmentTwo { get; set; }
    AssemblyJointOriginDefinitionTypeEnum OriginOneDefinitionType { get; }
    object OriginOneXOffset { get; }
    object OriginOneXOffsetReferencedGeometry { get; }
    object OriginOneYOffset { get; }
    object OriginOneYOffsetReferencedGeometry { get; }
    IFaceCollection OriginOneReferencedFaces { get; }
    AssemblyJointOriginDefinitionTypeEnum OriginTwoDefinitionType { get; }
    object OriginTwoXOffset { get; }
    object OriginTwoXOffsetReferencedGeometry { get; }
    object OriginTwoYOffset { get; }
    object OriginTwoYOffsetReferencedGeometry { get; }
    IFaceCollection OriginTwoReferencedFaces { get; }
    IAssemblyJointDefinition Copy();
    void SetOriginOneAsInfer();
    void SetOriginOneAsOffset(object XOffset, object YOffset);
    void SetOriginOneAsBetweenTwoFaces(IFaceCollection ReferencedFaces);
    void SetOriginTwoAsInfer();
    void SetOriginTwoAsOffset(object XOffset, object YOffset);
    void SetOriginTwoAsBetweenTwoFaces(IFaceCollection ReferencedFaces);
}