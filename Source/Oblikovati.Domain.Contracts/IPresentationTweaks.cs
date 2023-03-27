namespace Oblikovati.Domain.Contracts;

public interface IPresentationTweaks
{

    int Count { get; }
    IPresentationTweak Item { get; }
}
