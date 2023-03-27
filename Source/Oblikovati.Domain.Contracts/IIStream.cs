using Oblikovati.Domain.Contracts.Structs;

namespace Oblikovati.Domain.Contracts;

public interface IIStream : IISequentialStream
{
    void RemoteRead(out byte pv, uint cb, out uint pcbRead);
    void RemoteWrite(byte pv, uint cb, out uint pcbWritten);
    void RemoteSeek(long dlibMove, uint dwOrigin, out ulong plibNewPosition);
    void SetSize(ulong libNewSize);
    void RemoteCopyTo(IIStream pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);
    void Commit(uint grfCommitFlags);
    void Revert();
    void LockRegion(ulong libOffset, ulong cb, uint dwLockType);
    void UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);
    void Stat(out tagSTATSTG pstatstg, uint grfStatFlag);
    void Clone(out IIStream ppstm);
}
