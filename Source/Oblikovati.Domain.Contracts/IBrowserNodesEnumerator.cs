namespace Oblikovati.Domain.Contracts;

public interface IBrowserNodesEnumerator : IList<IBrowserNode>
{
    IBrowserNode ItemById(int Id);
}
