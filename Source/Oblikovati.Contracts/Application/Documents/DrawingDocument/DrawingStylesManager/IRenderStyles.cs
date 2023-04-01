namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IRenderStyles : IList<IRenderStyles>
{
    IRenderStyle Item { get; }

    IRenderStyle Add(string Name);
}