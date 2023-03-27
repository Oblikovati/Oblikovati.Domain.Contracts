namespace Oblikovati.Domain.Contracts;

public interface IProjectedCuts : IList<IProjectedCuts>
{

    int Count { get; }
    IProjectedCut Item { get; }
    IProjectedCut Add();
    IEnumerator GetEnumerator();
}
