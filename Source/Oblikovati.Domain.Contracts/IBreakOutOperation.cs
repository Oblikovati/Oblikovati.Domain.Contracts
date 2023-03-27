using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBreakOutOperation
{
    IObjectsEnumerator AllAffectedViews { get; }

    IAttributeSets AttributeSets { get; }
    BreakOutDepthTypeEnum DepthType { get; }
    IDrawingView Parent { get; }
    IProfile Profile { get; set; }
    bool SectionAllParts { get; set; }
    void Delete();
    void GetDepth(out object DepthSource, out double DepthValue);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetDepth(object DepthSource, double DepthValue);
}
