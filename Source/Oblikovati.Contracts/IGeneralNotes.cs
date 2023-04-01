using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts;

public interface IGeneralNotes : IList<IGeneralNotes>
{
    IGeneralNote Item { get; }


    IGeneralNote AddByRectangle(IPoint2d CornerOne, IPoint2d CornerTwo, string FormattedText, object TextStyle);
    IGeneralNote AddFitted(IPoint2d PlacementPoint, string FormattedText, object TextStyle);
}