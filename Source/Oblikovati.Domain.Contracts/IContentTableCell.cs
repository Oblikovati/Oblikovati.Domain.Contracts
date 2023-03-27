namespace Oblikovati.Domain.Contracts;

public interface IContentTableCell
{

    int Column { get; set; }
    IContentFamily Parent { get; }
    int Row { get; set; }
    string Value { get; set; }
    bool IsOverridden { get; }
}
