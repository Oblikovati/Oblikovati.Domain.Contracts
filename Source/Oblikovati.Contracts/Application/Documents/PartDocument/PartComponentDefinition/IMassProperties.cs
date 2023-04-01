using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IMassProperties
{
    double Volume { get; set; }
    double Area { get; }
    double Mass { get; set; }
    MassPropertiesAccuracyEnum Accuracy { get; set; }
    MassPropertiesAccuracyEnum AvailableAccuracy { get; }
    IPoint CenterOfMass { get; }
    double _AccuracyValue { get; }
    bool CacheResultsOnCompute { get; set; }
    bool IncludeCosmeticWelds { get; set; }
    bool IncludeQuantityOverrides { get; set; }
    bool MassOverridden { get; set; }
    bool VolumeOverridden { get; set; }

    void XYZMomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz,
        out double Ixz);

    void PrincipalMomentsOfInertia(out double I1, out double I2, out double I3);
    void RadiusOfGyration(out double Kx, out double Ky, out double Kz);
    void AchievedAccuracy(out double AchievedAccuracyArea, out double AchievedAccuracyVolume);
    void RotationToPrincipal(out double Rx, out double Ry, out double Rz);
}