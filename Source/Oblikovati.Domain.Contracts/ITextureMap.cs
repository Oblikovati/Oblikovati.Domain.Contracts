namespace Oblikovati.Domain.Contracts;

public interface ITextureMap
{


    IMatrix Transformation { get; }
    bool UseMask { get; }
    IColor MaskColor { get; }
    void GenerateImage(string FileName);
    ITextureCoordinateSet GetTextureCoordinateSet(double Tolerance);
}
