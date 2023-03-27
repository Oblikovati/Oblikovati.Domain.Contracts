namespace Oblikovati.Domain.Contracts;

public interface INormalToSurfaceWorkAxisDef
{

    IWorkAxis Parent { get; }
    object Point { get; }
    object SurfaceEntity { get; }
    void GetData(out object Point, out object SurfaceEntity);
}
