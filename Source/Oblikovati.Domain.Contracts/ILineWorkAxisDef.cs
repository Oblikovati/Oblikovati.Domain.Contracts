namespace Oblikovati.Domain.Contracts;

public interface ILineWorkAxisDef
{

    IWorkAxis Parent { get; }
    object Line { get; }
}
