using Oblikovati.Contracts.Structs;

namespace Oblikovati.Contracts;

public interface IIStream : IISequentialStream
{
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