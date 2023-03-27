using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBendDefinition
{

    IEdgeCollection Edges { get; set; }
    object BendRadius { get; set; }
    bool ExtendFaces { get; set; }
    DoubleBendTypeEnum DoubleBendType { get; set; }
    bool IsDoubleBendFirstEdgeFixed { get; set; }
    IBendOptions BendOptions { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }

    bool IsUnfoldMethodOverridden { get; set; }
    IBendDefinition Copy();
}
