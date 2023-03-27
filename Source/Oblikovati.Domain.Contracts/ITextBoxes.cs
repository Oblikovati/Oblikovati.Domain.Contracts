namespace Oblikovati.Domain.Contracts;

public interface ITextBoxes : IList<ITextBoxes>
{

    ITextBox Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ITextBox AddByRectangle(IPoint2d CornerOne, IPoint2d CornerTwo, string FormattedText, object TextStyle);
    ITextBox AddFitted(IPoint2d Position, string FormattedText, object TextStyle);
}
