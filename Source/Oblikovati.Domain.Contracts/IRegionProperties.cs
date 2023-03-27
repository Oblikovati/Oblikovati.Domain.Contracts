using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRegionProperties
{


    AccuracyEnum Accuracy { get; set; }
    double Area { get; }
    double Perimeter { get; }
    object Centroid { get; }
    double RotationAngle { get; }
    void PrincipalAxes(out IVector XAxis, out IVector YAxis);
    void PrincipalMomentsOfInertia(out double Ix, out double Iy, out double Iz);
    void MomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz);
    void RadiusOfGyration(out double Kxx, out double Kyy, out double Kzz);
    void GetTorsionProperties(out double Torsion, out double WorstStressValue, out IPoint WorstStressPosition, int FiniteElementNodeCount);
    void CentroidMomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz);
}
