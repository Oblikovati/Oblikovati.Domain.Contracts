namespace Oblikovati.Domain.Contracts;

public interface ICurveAndEntityWorkPointDef
{

    IWorkPoint Parent { get; }
    object CurveEntity { get; }
    object Entity { get; }
    void GetData(out object CurveEntity, out object Entity);
}
