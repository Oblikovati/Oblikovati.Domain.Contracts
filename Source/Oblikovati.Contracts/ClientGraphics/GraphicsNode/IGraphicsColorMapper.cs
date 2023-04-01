using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface IGraphicsColorMapper
{
    IColor Color { get; set; }
    int ColorCount { get; }
    IColor MappedColor { get; }
    double Value { get; set; }
    int ValueCount { get; }
    void Delete();
    void GetColors(ref List<byte> Colors);
    void GetValues(ref List<double> Values);
    void PutColors(List<byte> Colors);
    void PutValues(List<double> Values);
}