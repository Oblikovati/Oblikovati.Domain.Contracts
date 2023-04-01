using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ShellFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

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