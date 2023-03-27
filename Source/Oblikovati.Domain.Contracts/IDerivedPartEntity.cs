namespace Oblikovati.Domain.Contracts;

public interface IDerivedPartEntity
{
    object ReferencedEntity { get; }
    bool IncludeEntity { get; set; }

}
