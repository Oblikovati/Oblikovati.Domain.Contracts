using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICurveGraphics : IGraphicsPrimitive
{

    object Curve { get; set; }
    IColor Color { get; set; }
    int DepthPriority { get; set; }
    bool BurnThrough { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    CurveTypeEnum CurveType { get; }
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);
    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
