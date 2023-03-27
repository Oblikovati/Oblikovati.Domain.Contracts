namespace Oblikovati.Domain.Contracts;

public interface IRevolutionAndHeightCoilExtent
{

    IPartFeature Parent { get; }
    IParameter Height { get; }
    IParameter Revolution { get; }
    IParameter TaperAngle { get; }
}
