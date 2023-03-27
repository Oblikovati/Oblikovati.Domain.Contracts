namespace Oblikovati.Domain.Contracts;

public interface IGeneralNotes : IList<IGeneralNotes>
{

    IGeneralNote Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IGeneralNote AddByRectangle(IPoint2d CornerOne, IPoint2d CornerTwo, string FormattedText, object TextStyle);
    IGeneralNote AddFitted(IPoint2d PlacementPoint, string FormattedText, object TextStyle);
}
