using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IRevisionTableColumns : IList<IRevisionTableColumns>
{
    IRevisionTableColumn Item { get; }


    IRevisionTableColumn Add(RevisionTablePropertyEnum PropertyType, string PropertySetId, object PropertyIdentifier,
        int TargetIndex, bool InsertBefore);
}