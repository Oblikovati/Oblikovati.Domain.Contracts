using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILineStripGraphics : IGraphicsPrimitive
{
    IGraphicsCoordinateSet CoordinateSet { get; set; }
    IGraphicsIndexSet CoordinateIndexSet { get; set; }
    IGraphicsColorSet ColorSet { get; set; }
    IGraphicsIndexSet ColorIndexSet { get; set; }
    ColorBindingEnum ColorBinding { get; set; }
    int DepthPriority { get; set; }
    bool BurnThrough { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    void GetStripLengths(ref List<int> StripLengths);
    void PutStripLengths(ref List<int> StripLengths);
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);
    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
