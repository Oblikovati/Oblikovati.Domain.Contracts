using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts;

public interface IWorkSurfaces : IList<IWorkSurfaces>
{
    IWorkSurface Item { get; }
    IComponentDefinition Parent { get; }
}