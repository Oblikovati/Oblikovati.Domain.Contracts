using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ITextureMap
{
    IMatrix Transformation { get; }
    bool UseMask { get; }
    IColor MaskColor { get; }
    void GenerateImage(string FileName);
    ITextureCoordinateSet GetTextureCoordinateSet(double Tolerance);
}