namespace Oblikovati.Domain.Contracts;

public interface IPitchAndHeightCoilExtent
{

    IPartFeature Parent { get; }
    IParameter Pitch { get; }
    IParameter Height { get; }
    IParameter TaperAngle { get; }
}
