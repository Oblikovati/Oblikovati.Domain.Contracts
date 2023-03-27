using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPointCloudProxy
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
    IPointCloud NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete(bool RetainDependents);
    IPoint PointCloudToModelSpace(IPoint PointCloudCoordinate);
    IPoint ModelToPointCloudSpace(IPoint ModelCoordinate);
}
