using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMColumn
{
    string CustomPropertyName { get; }
    IDrawingBOM Parent { get; }
    PropertyTypeEnum PropertyType { get; }
    string Title { get; }
    void GetFilePropertyId(out string PropSetId, out int PropId);
}