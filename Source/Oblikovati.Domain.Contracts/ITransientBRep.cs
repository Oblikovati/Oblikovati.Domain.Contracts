using Oblikovati.Domain.Contracts.Application;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITransientBRep
{
    IApplicationUtilities ApplicationUtilities { get; }
    ISurfaceBody CreateSilhouetteCurve(IFace Face, IUnitVector ViewDirection, bool ReturnCoincidentSilhouettes);
    ISurfaceBody CreateSolidCylinderCone(IPoint BottomPoint, IPoint TopPoint, double BottomMajorRadius, double BottomMinorRadius, double TopMajorRadius, object MajorAxisPosition);
    ISurfaceBody CreateSolidSphere(IPoint Center, double Radius);
    ISurfaceBody CreateSolidTorus(IPoint Center, double MajorRadius, double MinorRadius);
    ISurfaceBody CreateSolidBlock(IBox Box);
    void DoBoolean(ISurfaceBody BlankBody, ISurfaceBody ToolBody, BooleanTypeEnum BooleanType);
    void Transform(ISurfaceBody SurfaceBody, IMatrix Transform);
    ISurfaceBody Copy(object Entity);
    ISurfaceBody CreateIntersectionWithPlane(ISurfaceBody Body, IPlane Plane);
    void DeleteFaces(object Faces, bool DeleteSpecifiedFaces);
    ISurfaceBodyDefinition CreateSurfaceBodyDefinition();
    ISurfaceBodies ReadFromFile(string FileName);
    ISurfaceBody CreateRuledSurface(IWire SectionOne, IWire SectionTwo);
    void WriteToFile(IObjectCollection Bodies, string FileName, string Format);
    void ImprintBodies(ISurfaceBody InputBodyOne, ISurfaceBody InputBodyTwo, bool ImprintCoincidentEdges, out ISurfaceBody OutputBodyOne, out ISurfaceBody OutputBodyTwo, out IFaces BodyOneOverlappingFaces, out IFaces BodyTwoOverlappingFaces, out IEdges BodyOneOverlappingEdges, out IEdges BodyTwoOverlappingEdges, double Tolerance);
    IObjectCollection GetIdenticalBodies(IObjectCollection InputSurfaceBodies, object Options);
}
