namespace Oblikovati.Domain.Contracts;

public interface ISingleHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Gap { get; }
    IParameter Length { get; }
}
