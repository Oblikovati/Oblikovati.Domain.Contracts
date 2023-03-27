namespace Oblikovati.Domain.Contracts;

public interface IISequentialStream
{
    void RemoteRead(out byte pv, uint cb, out uint pcbRead);
    void RemoteWrite(byte pv, uint cb, out uint pcbWritten);
}
