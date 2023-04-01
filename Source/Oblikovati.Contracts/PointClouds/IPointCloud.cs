using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloud
{
    string Name { get; }
    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    IBox RangeBox { get; }
    double Scale { get; set; }
    string SourceFullFileName { get; }
    IMatrix Transform { get; set; }
    bool Visible { get; set; }
    int TotalPointCount { get; }
    IBox RangeBoxInPointCloudSpace { get; }
    int Density { get; set; }
    int MaximumPointCount { get; set; }
    int DisplayedPointCount { get; }
    IPointCloudRegions Regions { get; }
    IPointCloudScans Scans { get; }
    IPointCloudCrops Crops { get; }
    double UnitsFactor { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete(bool RetainDependents);
    IPoint PointCloudToModelSpace(IPoint PointCloudCoordinate);
    IPoint ModelToPointCloudSpace(IPoint ModelCoordinate);
}