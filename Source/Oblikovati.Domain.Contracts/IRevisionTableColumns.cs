using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevisionTableColumns : IList<IRevisionTableColumns>
{

    IRevisionTableColumn Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRevisionTableColumn Add(RevisionTablePropertyEnum PropertyType, string PropertySetId, object PropertyIdentifier, int TargetIndex, bool InsertBefore);
}
