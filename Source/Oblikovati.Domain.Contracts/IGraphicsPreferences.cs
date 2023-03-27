namespace Oblikovati.Domain.Contracts;

public interface IGraphicsPreferences
{
    int _SwapType { get; set; }
    int _WorkAround { get; set; }
    bool _WorkAroundEffective { get; set; }
    bool _ActiveHiddenEdges { get; set; }
}
