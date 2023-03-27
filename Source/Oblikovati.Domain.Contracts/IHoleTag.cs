using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleTag
{

    IHoleTableRow Parent { get; }
    string Text { get; set; }
    string FormattedText { get; set; }
    bool Visible { get; set; }
    bool ShowLeader { get; set; }
    IPoint2d Position { get; set; }
    IDimensionStyle DimensionStyle { get; set; }
    ILayer Layer { get; set; }
    ILeader Leader { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IBox2d RangeBox { get; }
}
