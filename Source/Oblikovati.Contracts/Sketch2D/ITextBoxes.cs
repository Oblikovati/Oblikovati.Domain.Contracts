using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ITextBoxes : IList<ITextBoxes>
{
    ITextBox Item { get; }


    ITextBox AddByRectangle(IPoint2d CornerOne, IPoint2d CornerTwo, string FormattedText, object TextStyle);
    ITextBox AddFitted(IPoint2d Position, string FormattedText, object TextStyle);
}