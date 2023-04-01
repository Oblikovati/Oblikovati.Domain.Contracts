using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMComponentDescription
{
    IBIMComponentPropertySets ComponentPropertySets { get; }
    string ComponentType { get; set; }
    IObjectCollection ModelProperties { get; set; }
    IUserCoordinateSystem Orientation { get; set; }
    BIMComponentOrientationTypeEnum OrientationType { get; set; }
    IUserCoordinateSystem UserCoordinateSystemOrientation { get; set; }
    IPoint ViewCubeOrientationOrigin { get; set; }
    string FamilyType { get; set; }
    void SetCustomThumbnail(string FullFileName);
}