namespace Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

public interface IGeometricConstraints3D : IList<IGeometricConstraints3D>
{
    IGeometricConstraint3D Item { get; }


    ITangentConstraint3D AddTangent(ISketchEntity3D EntityOne, object EntityTwo, object ProximityPoint);
    ICollinearConstraint3D AddCollinear(object EntityOne, object EntityTwo, bool Reserved1, bool Reserved2);
    IGroundConstraint3D AddGround(ISketchEntity3D Entity);
    IParallelConstraint3D AddParallel(object EntityOne, object EntityTwo, bool Reserved1, bool Reserved2);
    IPerpendicularConstraint3D AddPerpendicular(object EntityOne, object EntityTwo, bool Reserved1, bool Reserved2);
    ICustomConstraint3D AddCustom(ISketchEntity3D Entity, string ClientId);
    ISmoothConstraint3D AddSmooth(ISketchEntity3D EntityOne, ISketchEntity3D EntityTwo, object ProximityPoint);
    ICoincidentConstraint3D AddCoincident(ISketchEntity3D EntityOne, ISketchEntity3D EntityTwo);
    IMidpointConstraint3D AddMidpoint(ISketchPoint3D Point, ISketchLine3D Line);
    IParallelToXAxisConstraint3D AddParallelToXAxis(ISketchLine3D Line);
    IParallelToYAxisConstraint3D AddParallelToYAxis(ISketchLine3D Line);
    IParallelToZAxisConstraint3D AddParallelToZAxis(ISketchLine3D Line);
    IParallelToXYPlaneConstraint3D AddParallelToXYPlane(ISketchEntity3D Entity);
    IParallelToYZPlaneConstraint3D AddParallelToYZPlane(ISketchEntity3D Entity);
    IParallelToXZPlaneConstraint3D AddParallelToXZPlane(ISketchEntity3D Entity);
    IEqualConstraint3D AddEqual(ISketchEntity3D EntityOne, ISketchEntity3D EntityTwo);
    IOnFaceConstraint3D AddOnFace(ISketchEntity3D Entity, object Face);
}