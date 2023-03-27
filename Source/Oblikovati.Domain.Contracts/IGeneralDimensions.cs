using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGeneralDimensions : IList<IGeneralDimensions>
{

    IGeneralDimension Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IGeneralDimensionsEnumerator Retrieve(object ViewOrSketch, object DimensionsToRetrieve);
    ILinearGeneralDimension AddLinear(IPoint2d TextOrigin, IGeometryIntent IntentOne, object IntentTwo, DimensionTypeEnum DimensionType, bool ArrowheadsInside, object DimensionStyle, object Layer);
    IAngularGeneralDimension AddAngular(IPoint2d TextOrigin, IGeometryIntent IntentOne, object IntentTwo, object IntentThree, bool ArrowheadsInside, bool UseQuadrant, bool OppositeAngle, object DimensionStyle, object Layer);
    IRadiusGeneralDimension AddRadius(IPoint2d TextOrigin, IGeometryIntent Intent, bool ArrowheadsInside, bool LeaderFromCenter, bool Jogged, object DimensionStyle, object Layer);
    IDiameterGeneralDimension AddDiameter(IPoint2d TextOrigin, IGeometryIntent Intent, bool ArrowheadsInside, bool LeaderFromCenter, bool SingleDimensionLine, object DimensionStyle, object Layer);
    IObjectCollection GetRetrievableDimensions(IDrawingView View, object ModelObject);
    ILinearGeneralDimension AddLinearForeshortened(IPoint2d TextOrigin, IGeometryIntent IntentOne, IGeometryIntent IntentTwo, bool HideSecondArrowhead, object DimensionStyle, object Layer);
    ILinearGeneralDimension AddArcLengthForeshortened(IPoint2d TextOrigin, IGeometryIntent IntentOne, object IntentTwo, object IntentThree, object VirtualArcPosition, bool HideSecondArrowhead, bool UseQuadrant, bool OppositeAngle, object DimensionStyle, object Layer);
    IAngularGeneralDimension AddAngularForeshortened(IPoint2d TextOrigin, IGeometryIntent IntentOne, object IntentTwo, object IntentThree, bool HideSecondArrowhead, bool UseQuadrant, bool OppositeAngle, object DimensionStyle, object Layer);
    ILinearGeneralDimension AddLinear2(IPoint2d TextOrigin, IGeometryIntent IntentOne, object IntentTwo, DimensionTypeEnum DimensionType, object AlignmentGeometry, bool ArrowheadsInside, object DimensionStyle, object Layer);
}
