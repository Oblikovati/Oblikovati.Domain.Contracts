using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleTapInfo
{

    string ThreadType { get; set; }
    string ThreadTypeIdentifier { get; }
    bool Metric { get; set; }
    bool Internal { get; set; }
    bool RightHanded { get; set; }
    string _NominalSizeDescription { get; set; }
    string ThreadDesignation { get; }
    string CustomThreadDesignation { get; }
    IObjectsEnumerator ThreadBasePoints { get; }
    IUnitVector _ThreadDirection { get; }
    IVector ThreadDirection { get; }
    bool FullThreadDepth { get; set; }
    string _PitchDesignation { get; set; }
    string Class { get; set; }
    object MajorDiameterMax { get; set; }
    object MajorDiameterMin { get; set; }
    object MinorDiameterMax { get; set; }
    object MinorDiameterMin { get; set; }
    object PitchDiameterMax { get; set; }
    object PitchDiameterMin { get; set; }
    object TapDrillDiameter { get; set; }
    string NominalSize { get; }
    double Pitch { get; }
    ModelDiameterFromThreadEnum _DiameterInModel { get; set; }
    bool FullTapDepth { get; set; }
    IParameter ThreadDepth { get; }
}
