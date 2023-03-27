using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IContentTableColumns : IList<IContentTableColumns>
{

    int Count { get; }
    IContentTableColumn Item { get; }
    IContentTableColumn Add(string InternalName, string DisplayHeading, ValueTypeEnum DataType, object Units, object Expression, object PropertySetId, object PropertyIdentifier);
    IExpressionLimits CreateExpressionLimits();
    IEnumerator GetEnumerator();
}
