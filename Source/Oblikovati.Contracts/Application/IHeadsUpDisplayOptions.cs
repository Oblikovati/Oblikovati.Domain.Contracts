using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application;

public interface IHeadsUpDisplayOptions
{
    ISketchOptions Parent { get; }
    bool CreateDimensionsOnValueInput { get; set; }
    bool DimensionInputEnabled { get; set; }
    bool DimensionInputInCartesianCoordinates { get; set; }
    bool Enabled { get; set; }
    bool PointerInputEnabled { get; set; }
    bool PointerInputInCartesianCoordinates { get; set; }
}