using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTweak
{
    string Name { get; }
    TweakTypeEnum TweakType { get; }
    IVector Translation { get; }
    ITrailSegmentsEnumerator TrailSegments { get; }
    void GetRotationData(out IUnitVector Axis, out IPoint BasePoint, out double Angle);
}