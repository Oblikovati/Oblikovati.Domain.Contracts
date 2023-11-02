namespace Oblikovati.Contracts.NotClassified;

public interface ITorusCenterPointWorkPointDef
{
    IWorkPoint Parent { get; }
    IFace Face { get; }
}