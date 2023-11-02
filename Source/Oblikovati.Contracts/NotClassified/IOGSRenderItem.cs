using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IOGSRenderItem
{
    IColor AmbientColor { get; }
    IColor DiffuseColor { get; }
    IColor SpecularColor { get; }
    IColor EmissiveColor { get; }
    IColor TransmissionColor { get; }
    double Opacity { get; }
    double AmbientFactor { get; }
    double DiffuseFactor { get; }
    double Shininess { get; }
    double Gloss { get; }
    OGSGeometryTypeEnum OGSGeometryType { get; }
    OGSPrimitiveTypeEnum OGSPrimitiveType { get; }
    string TextureFilename { get; }
    IOGSRenderItemsEnumerator SubRenderItems { get; }
    IMatrix TextureTransformation { get; }
    IMatrix Transformation { get; }

    void GetVerticesData(out int VertexCount, out List<double> VertexCoordinates, out List<double> NormalVectors,
        out List<int> VertexIndices, out List<double> TextureCoordinates);
}