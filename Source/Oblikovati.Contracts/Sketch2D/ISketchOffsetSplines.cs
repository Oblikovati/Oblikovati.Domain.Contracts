namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchOffsetSplines : IList<ISketchOffsetSplines>
{
    ISketchOffsetSpline Item { get; }
}