namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface ITextStyles : IList<ITextStyles>
{
    ITextStyle Item { get; }
}