namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMCell
{

    IDrawingBOM Parent { get; }
    bool Static { get; }
    string Value { get; }
}
