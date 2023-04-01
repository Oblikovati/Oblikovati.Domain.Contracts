namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IStyles : IList<IStyles>
{
    IStyle Item { get; }
}