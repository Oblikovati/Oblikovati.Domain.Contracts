using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
