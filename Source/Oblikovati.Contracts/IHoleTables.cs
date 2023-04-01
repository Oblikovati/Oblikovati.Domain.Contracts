using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics.DrawingView;

namespace Oblikovati.Contracts;

public interface IHoleTables : IList<IHoleTables>
{
    IHoleTable Item { get; }


    IHoleTable Add(IDrawingView DrawingView, IPoint2d PlacementPoint, object HoleTableStyle, object Layer);
    IHoleTable AddSelected(IObjectCollection Holes, IPoint2d PlacementPoint, object HoleTableStyle, object Layer);

    IHoleTable AddByFeatureType(IDrawingView DrawingView, IPoint2d PlacementPoint, bool IncludeDrilledHoleFeatures,
        bool IncludeCounterBoreHoleFeatures, bool IncludeCounterSinkHoleFeatures, bool IncludeThreadedHoleFeatures,
        bool IncludeCircularCuts, bool IncludeCentermarks, bool IncludeRecoveredPunchCenters, object HoleTableStyle,
        object Layer);
}