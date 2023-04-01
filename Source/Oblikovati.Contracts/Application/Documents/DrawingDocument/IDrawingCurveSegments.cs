namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingCurveSegments : IList<IDrawingCurveSegments>
{
    IDrawingCurveSegment Item { get; }
}