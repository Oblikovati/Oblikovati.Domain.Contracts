namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAssetLibraries : IList<IAssetLibrary>
{
    IAssetLibrary Add(string FullFileName);
    IAssetLibrary Open(string FullFileName);
    void MigrateOblikovatiStyle(string OblikovatiLibraryPath, bool ImportMaterialStyles, string TargetLibrary);
}