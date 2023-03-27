namespace Oblikovati.Domain.Contracts;

public interface IBalloonTipObject
{
    bool Enabled { get; set; }
    string InternalName { get; }
    IUserInterfaceManager Parent { get; }
    int Interval { get; set; }
    string Message { get; set; }
    string ClientData { get; set; }
    void Delete();
    void Display(string Message);
}
