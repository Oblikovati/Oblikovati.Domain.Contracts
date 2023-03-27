using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGraphicsPrimitive
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
