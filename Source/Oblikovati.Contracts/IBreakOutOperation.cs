using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

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