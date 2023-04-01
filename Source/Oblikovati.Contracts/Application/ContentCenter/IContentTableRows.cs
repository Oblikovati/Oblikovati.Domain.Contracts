namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentTableRows : IList<IContentTableRows>
{
    IContentTableRow Item { get; }
    IContentTableRow Add(ref List<string> RowData, int Position);
}