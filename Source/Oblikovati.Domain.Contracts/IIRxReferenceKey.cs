namespace Oblikovati.Domain.Contracts;

public interface IIRxReferenceKey
{
    Guid ObjectType { get; }
    IntPtr Key { get; }
    int TransientKey { get; }
    Guid RevisionId { get; }
}
