using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleTableCell
{

    IHoleTable Parent { get; }
    string Text { get; set; }
    string FormattedText { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
}
