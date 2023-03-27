namespace Oblikovati.Domain.Contracts;

public interface IDoubleHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Gap { get; }
    IParameter Length { get; }
}
