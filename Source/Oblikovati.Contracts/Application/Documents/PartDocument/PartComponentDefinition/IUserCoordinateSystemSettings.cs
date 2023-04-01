using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IUserCoordinateSystemSettings
{
    string NamingPrefix { get; set; }
    bool ShowTriad { get; set; }
    bool ShowOrigin { get; set; }
    bool ShowXAxis { get; set; }
    bool ShowYAxis { get; set; }
    bool ShowZAxis { get; set; }
    bool ShowXYPlane { get; set; }
    bool ShowXZPlane { get; set; }
    bool ShowYZPlane { get; set; }
    CoordinateSystemPlaneEnum DefaultPlane { get; set; }
}