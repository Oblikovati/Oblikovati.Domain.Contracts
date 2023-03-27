namespace Oblikovati.Domain.Contracts;

public interface ICutAcrossBendsExtent
{

    IPartFeature Parent { get; }
    IParameter Distance { get; }
}
