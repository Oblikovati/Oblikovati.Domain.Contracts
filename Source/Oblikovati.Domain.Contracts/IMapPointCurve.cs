namespace Oblikovati.Domain.Contracts;

public interface IMapPointCurve
{

    int PointCount { get; }
    void SetPosition(object Entity, double Value);
    void SetPositionUsingPoint(int SectionIndex, IPoint Position);
    void GetPosition(int Index, out object Entity, out double Result);
    IPoint GetPositionPoint(int Index);
    void Delete();
}
