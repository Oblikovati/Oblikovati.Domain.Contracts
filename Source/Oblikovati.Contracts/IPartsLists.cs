using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPartsLists : IList<IPartsLists>
{
    IPartsList Item { get; }


    IPartsList Add(object ViewOrModel, IPoint2d PlacementPoint, PartsListLevelEnum Level, object NumberingScheme,
        int NumberOfSections, bool WrapLeft);
}