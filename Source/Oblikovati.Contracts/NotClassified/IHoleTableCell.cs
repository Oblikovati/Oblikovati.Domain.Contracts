using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IHoleTableCell
{
    IHoleTable Parent { get; }
    string Text { get; set; }
    string FormattedText { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
}