using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICenterline
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Visible { get; set; }
    CenterlineTypeEnum CenterlineType { get; }
    object ModelWorkFeature { get; }
    bool Attached { get; }
    IPoint2d StartPoint { get; set; }
    IPoint2d EndPoint { get; set; }
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    ILayer Layer { get; set; }
    ICentermarkStyle Style { get; set; }
    IObjectsEnumerator FitPoints { get; }
    IGeometryIntent PatternCenter { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void GetBisectorEntities(out IGeometryIntent EntityOne, out IGeometryIntent EntityTwo);
}
