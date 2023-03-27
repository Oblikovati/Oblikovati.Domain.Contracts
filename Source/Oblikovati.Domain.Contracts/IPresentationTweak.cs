using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationTweak
{


    string Name { get; }
    TweakTypeEnum TweakType { get; }
    IVector Translation { get; }
    ITrailSegmentsEnumerator TrailSegments { get; }
    void GetRotationData(out IUnitVector Axis, out IPoint BasePoint, out double Angle);
}
