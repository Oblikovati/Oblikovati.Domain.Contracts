using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IImportedDWGComponentDefinition
{
    IImportedComponent Parent { get; }
    string FullFileName { get; }
    IMatrix Transformation { get; set; }
    object DWGReferenceOrigin { get; set; }
    object LocationPlane { get; set; }
    object LocationOrigin { get; set; }
    IPoint2d DWGReferenceOriginInLocationPlane { get; set; }
    object DWGRotationInLocationPlane { get; set; }
    ImportDWGBodyStyleEnum ImportDWGBodyStyle { get; set; }
    IImportedDWGComponentDefinition Copy();
    void SetLocation(object LocationPlane, object LocationOrigin);
}