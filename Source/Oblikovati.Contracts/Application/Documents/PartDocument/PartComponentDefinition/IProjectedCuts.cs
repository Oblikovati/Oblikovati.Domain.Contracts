namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IProjectedCuts : IList<IProjectedCuts>
{
    IProjectedCut Item { get; }
    IProjectedCut Add();
}