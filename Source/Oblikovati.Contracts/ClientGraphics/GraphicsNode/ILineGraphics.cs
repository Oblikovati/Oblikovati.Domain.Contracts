using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ILineGraphics : IGraphicsPrimitive
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
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);

    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType,
        out double PixelScale);

    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}