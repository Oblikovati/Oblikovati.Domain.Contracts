namespace Oblikovati.Domain.Contracts;

public interface IProgressBarObject
{

    string Message { get; set; }
    void UpdateProgress();
    void Close();
}
