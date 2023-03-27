using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
