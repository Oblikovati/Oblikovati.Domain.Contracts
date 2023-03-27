namespace Oblikovati.Domain.Contracts;

public interface ITorusCenterPointWorkPointDef
{

    IWorkPoint Parent { get; }
    IFace Face { get; }
}
