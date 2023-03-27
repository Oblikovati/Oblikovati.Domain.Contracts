namespace Oblikovati.Domain.Contracts;

public interface ISketchBlocks : IList<ISketchBlocks>
{
    ISketchBlock Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchBlock Add(IObjectCollection SketchObjects, string Name, object InsertionPoint);
    ISketchBlock AddByDefinition(ISketchBlockDefinition Definition, IPoint2d Position);
}
