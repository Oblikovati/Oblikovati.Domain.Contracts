using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IBreakOperation
{
    IObjectsEnumerator AllAffectedViews { get; }

    IAttributeSets AttributeSets { get; }
    BreakStyleEnum BreakStyle { get; set; }
    int DisplayLevel { get; set; }
    IPoint2d EndPoint { get; set; }
    double Gap { get; set; }
    bool IsSourceBreakOperation { get; }
    ILayer Layer { get; set; }
    IPoint2d MidPoint { get; set; }
    int NumberOfSymbols { get; set; }
    BreakOrientationEnum Orientation { get; }
    IDrawingView Parent { get; }
    IBreakOperation SourceBreakOperation { get; }
    IPoint2d StartPoint { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}