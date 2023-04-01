namespace Oblikovati.Contracts.Application.ProgressBar;

public interface IProgressBarObject
{
    string Message { get; set; }
    void UpdateProgress();
    void Close();
}