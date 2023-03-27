namespace Oblikovati.Domain.Contracts.Rendering;

public interface IShaderResourceDeclaration
{
    string GetName();
	uint GetRegister();
	uint GetCount();
}