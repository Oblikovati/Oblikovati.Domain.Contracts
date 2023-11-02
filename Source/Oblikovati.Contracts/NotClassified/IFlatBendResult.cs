using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.BendFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IFlatBendResult
{
    IFlatPattern Parent { get; }
    string InternalName { get; }
    IEdge Edge { get; }
    bool IsDirectionUp { get; }
    double Angle { get; }
    double InnerRadius { get; }
    bool IsOnBottomFace { get; }
    double kFactor { get; }
    IBend Bend { get; }
    void GetBendOrder(out int BenderOrder, out BendOrderSourceTypeEnum BendOrderSourceType);
    void SetBendOrder(int BenderOrder, bool AllowDuplicate);
}