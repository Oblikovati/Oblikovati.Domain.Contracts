namespace Oblikovati.Domain.Contracts;

public interface IAssemblyWorkAxisDef
{

    IWorkAxis Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint OriginPoint { get; }
    IUnitVector Axis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector Axis);
    void PutData(IPoint OriginPoint, IUnitVector Axis);
}
