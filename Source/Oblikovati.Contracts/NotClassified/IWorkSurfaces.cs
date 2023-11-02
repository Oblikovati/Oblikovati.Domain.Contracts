using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.NotClassified;

public interface IWorkSurfaces : IList<IWorkSurfaces>
{
    IWorkSurface Item { get; }
    IComponentDefinition Parent { get; }
}