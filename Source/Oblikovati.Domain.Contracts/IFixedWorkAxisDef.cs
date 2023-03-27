namespace Oblikovati.Domain.Contracts;

public interface IFixedWorkAxisDef
{

    IWorkAxis Parent { get; }
    IPoint OriginPoint { get; }
    IUnitVector Axis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector Axis);
    void PutData(IPoint OriginPoint, IUnitVector Axis);
}
