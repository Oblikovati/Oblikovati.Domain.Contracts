namespace Oblikovati.Domain.Contracts;

public interface IFlatPatternSettings
{

    IDocument Parent { get; }
    bool DeferUpdate { get; set; }
}
