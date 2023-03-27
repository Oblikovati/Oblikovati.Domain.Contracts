namespace Oblikovati.Domain.Contracts;

public interface IAssemblyWorkPlaneDef
{

    IWorkPlane Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint OriginPoint { get; }
    IUnitVector XAxis { get; }
    IUnitVector YAxis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector XAxis, out IUnitVector YAxis);
    void PutData(IPoint OriginPoint, IUnitVector XAxis, IUnitVector YAxis);
}
