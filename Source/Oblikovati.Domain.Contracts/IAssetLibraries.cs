namespace Oblikovati.Domain.Contracts;

public interface IAssetLibraries : IList<IAssetLibrary>
{

    IAssetLibrary Add(string FullFileName);
    IAssetLibrary Open(string FullFileName);
    void MigrateOblikovatiStyle(string OblikovatiLibraryPath, bool ImportMaterialStyles, string TargetLibrary);
}
