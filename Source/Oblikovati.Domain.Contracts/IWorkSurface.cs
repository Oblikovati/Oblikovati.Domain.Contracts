namespace Oblikovati.Domain.Contracts;

public interface IWorkSurface
{

    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    ISurfaceBody _SurfaceBody { get; }
    IWorkSurface ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Translucent { get; set; }
    bool Visible { get; set; }
    bool Suppressed { get; }
    ISurfaceBodies SurfaceBodies { get; }
    bool Exported { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
