namespace Oblikovati.Domain.Contracts;

public interface IFixedWorkPlaneDef
{

    IWorkPlane Parent { get; }
    IPoint OriginPoint { get; }
    IUnitVector XAxis { get; }
    IUnitVector YAxis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector XAxis, out IUnitVector YAxis);
    void PutData(IPoint OriginPoint, IUnitVector XAxis, IUnitVector YAxis);
}
