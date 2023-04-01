using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.ClientGraphics.GraphicsNode;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ClientGraphics;

public interface IClientGraphics : IList<IGraphicsNode>
{
    IClientGraphicsCollection Parent { get; }

    IGraphicsNode this[string index] { get; }
    string ClientId { get; }
    IBox RangeBox { get; }
    GraphicsSelectabilityEnum Selectable { get; set; }
    GraphicsVisibilityEnum Visible { get; set; }
    bool NonTransacting { get; }
    IGraphicsNode AddNode(int NodeId);
    void Delete();
}