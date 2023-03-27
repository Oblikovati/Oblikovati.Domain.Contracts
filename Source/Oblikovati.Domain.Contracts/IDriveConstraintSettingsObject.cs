using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDriveConstraintSettingsObject
{

    bool CollisionDetection { get; set; }
    bool DriveAdaptivity { get; set; }
    string EndValue { get; set; }
    int FrameRate { get; set; }
    IAssemblyConstraint Parent { get; }
    double PauseDelay { get; set; }
    int RepetitionCount { get; set; }
    bool RepetitionStartEndStart { get; set; }
    string StartValue { get; set; }
    bool IsInitialized { get; }
    void GetIncrement(out ConstraintIncrementTypeEnum IncrementType, out string Increment);
    void GoToStart();
    void GoToEnd();
    void PlayForward();
    void PlayReverse();
    void SetIncrement(ConstraintIncrementTypeEnum IncrementType, string Increment);
    void StartAVIRecording(string FullFileName, string Compressor, int CompressionQuality, object MoreOptions);
    void StartWMVRecording(string FullFileName, int NetworkBandwidth, int ImageWidth, int ImageHeight, bool AddMarkers, object MoreOptions);
    void StepForward();
    void StepReverse();
    void StopRecording();
}
