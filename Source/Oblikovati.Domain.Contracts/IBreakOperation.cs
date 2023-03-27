using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
