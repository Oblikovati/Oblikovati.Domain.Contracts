namespace Oblikovati.Domain.Contracts;

public interface ITaperedThreadInfo
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
    string ThreadsPerInch { get; set; }
    double Pitch { get; set; }
    object OutsidePipeDiameter { get; set; }
    object ExternalPitchDiameter { get; set; }
    object EngagementLength { get; set; }
    object EngagementDiameter { get; set; }
    object EffectiveLength { get; set; }
    object EffectiveDiameter { get; set; }
    object WrenchMakeupLength { get; set; }
    object WrenchMakeupDiameter { get; set; }
    object VanishThread { get; set; }
    object OverallExternalLength { get; set; }
    object NominalExternalLength { get; set; }
    object NominalExternalDiameter { get; set; }
    object ThreadHeight { get; set; }
    object BasicMinorDiameter { get; set; }
    object TapDrillDiameter { get; set; }
}
