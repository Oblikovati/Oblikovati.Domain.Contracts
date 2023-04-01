using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentTableColumns : IList<IContentTableColumns>
{
    IContentTableColumn Item { get; }

    IContentTableColumn Add(string InternalName, string DisplayHeading, ValueTypeEnum DataType, object Units,
        object Expression, object PropertySetId, object PropertyIdentifier);

    IExpressionLimits CreateExpressionLimits();
}