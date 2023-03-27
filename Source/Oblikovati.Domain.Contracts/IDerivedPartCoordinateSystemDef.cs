using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDerivedPartCoordinateSystemDef
{

    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    bool IncludeAllParameters { get; set; }
    bool IncludeBody { get; set; }
    bool BodyAsSolidBody { get; set; }
    IDerivedPartEntities Surfaces { get; }
    IDerivedPartEntities iMateDefinitions { get; }
    IDerivedPartEntities Parameters { get; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    IDerivedPartEntities Solids { get; }
    DerivedComponentOptionEnum IncludeAlliMateDefinitions { get; set; }
    string ActiveDesignViewRepresentation { get; set; }
    bool IsAssociativeDesignView { get; set; }
    bool ReducedMemoryMode { get; set; }
    bool UseColorOverridesFromSource { get; set; }
    string ActiveModelState { get; set; }
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    void IncludeAll();
    void ExcludeAll();
    void GetScale(out double XScale, out double YScale, out double ZScale);
    void SetScale(double XScale, double YScale, double ZScale);
    void GetCoordinateSystem(out IPoint Origin, out IVector XAxis, out IVector YAxis, out IVector ZAxis);
    void SetCoordinateSystem(IPoint Origin, IVector XAxis, IVector YAxis);
}
