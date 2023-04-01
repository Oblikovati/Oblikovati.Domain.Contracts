using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IAutoCADBlocks : IList<IAutoCADBlocks>
{
    IAutoCADBlock Item { get; }


    IAutoCADBlock Add(IAutoCADBlockDefinition Definition, IPoint2d Position, double Rotation, double Scale,
        object PromptStrings, bool Static);
}