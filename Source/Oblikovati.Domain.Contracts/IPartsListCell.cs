namespace Oblikovati.Domain.Contracts;

public interface IPartsListCell
{

    IPartsList Parent { get; }
    string Value { get; set; }
    bool Static { get; set; }
    bool UpToDate();
    void Update();
}
