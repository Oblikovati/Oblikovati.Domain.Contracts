namespace Oblikovati.Domain.Contracts;

public interface IBend
{

    ISheetMetalComponentDefinition Parent { get; }
    IFaces BackFaces { get; }
    IFaces FrontFaces { get; }
    bool IsFlat { get; }
}
