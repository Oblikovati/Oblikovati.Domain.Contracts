namespace Oblikovati.Domain.Contracts;

public interface ISphereCenterPointWorkPointDef
{

    IWorkPoint Parent { get; }
    IFace Face { get; }
}
