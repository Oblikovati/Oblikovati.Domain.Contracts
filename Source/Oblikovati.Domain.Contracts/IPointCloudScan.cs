namespace Oblikovati.Domain.Contracts;

public interface IPointCloudScan
{

    string DisplayName { get; }
    string InternalName { get; }
    IPointCloud Parent { get; }
    string SourceFullFileName { get; }
    bool Visible { get; set; }
    IPoint Origin { get; }
}
