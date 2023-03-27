namespace Oblikovati.Domain.Contracts.Rendering;

public interface IShaderLibrary
{
    void Add(IShader shader);
    void Load(string path, bool forceCompile = false, bool disableOptimization = false);
    void Load(string name, string path);
    void LoadShaderPack(string path);
    IShader Get(string name);
    ulong GetSize();
    Dictionary<string, IShader> GetShaders();
}