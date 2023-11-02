using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FaceOffsetFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IFaceOffsetDefinition
{
    bool _AutomaticFaceChain { get; }
    bool _Reverse { get; set; }
    IFaceOffsetFeature Parent { get; }
    IParameter _Distance { get; }
    IFaceCollection _InputFaces { get; set; }
    FeatureApproximationTypeEnum _ApproximationType { get; set; }
    bool _ApproximationOptimized { get; set; }
    double _ApproximationTolerance { get; set; }
    IFaceOffsetDefinition _Copy();
}