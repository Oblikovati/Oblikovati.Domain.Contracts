using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMColumn
{

    string CustomPropertyName { get; }
    IDrawingBOM Parent { get; }
    PropertyTypeEnum PropertyType { get; }
    string Title { get; }
    void GetFilePropertyId(out string PropSetId, out int PropId);
}
