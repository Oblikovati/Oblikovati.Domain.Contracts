using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IDriveSettingsObject
{
    bool CollisionDetection { get; set; }
    bool DriveAdaptivity { get; set; }
    DriveTypeEnum DriveType { get; set; }
    string EndValue { get; set; }
    int FrameRate { get; set; }
    bool IsInitialized { get; }

    double PauseDelay { get; set; }
    int RepetitionCount { get; set; }
    bool RepetitionStartEndStart { get; set; }
    string StartValue { get; set; }
    void GetIncrement(out IncrementTypeEnum IncrementType, out string Increment);
    void GoToStart();
    void GoToEnd();
    void PlayForward();
    void PlayReverse();
    void SetIncrement(IncrementTypeEnum IncrementType, string Increment);
    void StartAVIRecording(string FullFileName, string Compressor, int CompressionQuality, object MoreOptions);

    void StartWMVRecording(string FullFileName, int NetworkBandwidth, int ImageWidth, int ImageHeight, bool AddMarkers,
        object MoreOptions);

    void StepForward();
    void StepReverse();
    void StopRecording();
}