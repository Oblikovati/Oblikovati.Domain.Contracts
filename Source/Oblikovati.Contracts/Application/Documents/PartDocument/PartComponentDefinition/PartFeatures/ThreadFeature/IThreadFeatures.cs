using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ThreadFeature;

public interface IThreadFeatures : IList<IThreadFeatures>
{
    IThreadFeature Item { get; }


    IStandardThreadInfo _CreateStandardThreadInfo(bool Metric, bool Internal, bool RightHanded,
        string NominalSizeDescription, string PitchDesignation, string Class, string ThreadType,
        object MajorDiameterMin, object MajorDiameterMax, object MinorDiameterMin, object MinorDiameterMax,
        object PitchDiameterMin, object PitchDiameterMax);

    ITaperedThreadInfo _CreateTaperedThreadInfo(bool Metric, bool Internal, bool RightHanded,
        string NominalSizeDescription, string ThreadsPerInch, double Pitch, string ThreadType,
        object OutsidePipeDiameter, object ExternalPitchDiameter, object EngagementLength, object EngagementDiameter,
        object EffectiveLength, object EffectiveDiameter, object WrenchMakeupLength, object WrenchMakeupDiameter,
        object VanishThread, object OverallExternalLength, object NominalExternalLength, object NominalExternalDiameter,
        object ThreadHeight, object BasicMinorDiameter);

    IThreadFeature Add(IFace Face, IEdge StartEdge, IThreadInfo ThreadInfo, bool DirectionReversed, bool FullDepth,
        object ThreadDepth, object ThreadOffset);

    IThreadInfo CreateThreadInfo(bool Internal, bool RightHanded, string ThreadType, string ThreadDesignation,
        string Class);

    IStandardThreadInfo CreateStandardThreadInfo(bool Internal, bool RightHanded, string ThreadType,
        string ThreadDesignation, string Class);

    ITaperedThreadInfo CreateTaperedThreadInfo(bool Internal, bool RightHanded, string ThreadType,
        string ThreadDesignation);
}