namespace Oblikovati.Domain.Contracts;

public interface IReferencedOpaqueFileDescriptor
{


    string FullFileName { get; }
    void Delete();
}
