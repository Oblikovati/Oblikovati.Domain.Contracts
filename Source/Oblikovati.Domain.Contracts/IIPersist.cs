namespace Oblikovati.Domain.Contracts;

public interface IIPersist
{
    void GetClassID(out Guid pClassID);
}
