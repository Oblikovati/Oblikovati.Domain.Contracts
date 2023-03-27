using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPartsLists : IList<IPartsLists>
{

    IPartsList Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPartsList Add(object ViewOrModel, IPoint2d PlacementPoint, PartsListLevelEnum Level, object NumberingScheme, int NumberOfSections, bool WrapLeft);
}
