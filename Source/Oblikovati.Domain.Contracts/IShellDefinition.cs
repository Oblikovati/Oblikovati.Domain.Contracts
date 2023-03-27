using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IShellDefinition
{

    ShellDirectionEnum Direction { get; set; }
    int FaceSetCount { get; }
    IShellFeature Parent { get; }
    IParameter Thickness { get; }
    IShellThicknessFaceSet FaceSetItem { get; }
    IFaceCollection InputFaces { get; set; }
    FeatureApproximationTypeEnum ApproximationType { get; set; }
    bool ApproximationOptimized { get; set; }
    double ApproximationTolerance { get; set; }
    IShellThicknessFaceSet AddThicknessFaceSet(IFaceCollection Faces, object Thickness);
    IShellDefinition Copy();
}
