namespace Oblikovati.Domain.Contracts;

public interface ISpiralCoilExtent
{

    IPartFeature Parent { get; }
    IParameter Pitch { get; }
    IParameter Revolution { get; }
}
