namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;

public interface IBOMViews : IList<IBOMViews>
{
    IBOMView Item { get; }
}