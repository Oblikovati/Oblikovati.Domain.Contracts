namespace Oblikovati.Domain.Contracts;

public interface IAutoCADBlocks : IList<IAutoCADBlocks>
{

    IAutoCADBlock Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IAutoCADBlock Add(IAutoCADBlockDefinition Definition, IPoint2d Position, double Rotation, double Scale, object PromptStrings, bool Static);
}
