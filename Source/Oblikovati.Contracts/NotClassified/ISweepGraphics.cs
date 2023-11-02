using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.ClientGraphics.GraphicsNode;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ISweepGraphics
{
    IGraphicsNode Parent { get; }

    IBox RangeBox { get; }
    bool Anchored { get; }
    int Id { get; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
}