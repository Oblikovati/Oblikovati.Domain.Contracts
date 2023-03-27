namespace Oblikovati.Domain.Contracts;

public interface IToHeightExtent
{

    IPartFeature Parent { get; }
    IParameter Offset { get; }
    object ToEntity { get; }
}
