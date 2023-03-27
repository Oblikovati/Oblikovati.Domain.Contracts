namespace Oblikovati.Domain.Contracts;

public interface IObjectVisibility
{

    IDocument Parent { get; }
    bool AllWorkFeatures { get; set; }
    bool ConstructionSurfaces { get; set; }
    bool GroupDiagnostics { get; set; }
    bool GroupSolids { get; set; }
    bool GroupSurfaces { get; set; }
    bool GroupWires { get; set; }
    bool OriginWorkAxes { get; set; }
    bool OriginWorkPlanes { get; set; }
    bool OriginWorkPoints { get; set; }
    bool Sketches { get; set; }
    bool Sketches3D { get; set; }
    bool UCSTriads { get; set; }
    bool UCSWorkAxes { get; set; }
    bool UCSWorkPlanes { get; set; }
    bool UCSWorkPoints { get; set; }
    bool UserWorkAxes { get; set; }
    bool UserWorkPlanes { get; set; }
    bool UserWorkPoints { get; set; }
    bool Welds { get; set; }
    bool WeldmentSymbols { get; set; }
    bool SketchDimensions { get; set; }
    bool Annotations3D { get; set; }
    bool ComponentAnnotations3D { get; set; }
}
