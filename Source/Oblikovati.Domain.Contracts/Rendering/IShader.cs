namespace Oblikovati.Domain.Contracts.Rendering;

public interface IShader
{
    void Reload(bool forceCompile = false);
	void RT_Reload(bool forceCompile);
	ulong GetHash();
    string GetName();
    void SetMacro(string name, string value);
    IShader Create(string filepath, bool forceCompile = false, bool disableOptimization = false);
	IShader LoadFromShaderPack(string filepath, bool forceCompile = false, bool disableOptimization = false);
	IShader CreateFromString(string source);
	Dictionary<string, ShaderBuffer> GetShaderBuffers();
	Dictionary<string, IShaderResourceDeclaration> GetResources();
}