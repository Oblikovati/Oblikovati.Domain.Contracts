namespace Oblikovati.Domain.Contracts.Rendering;

public enum ShaderUniformType
{
    None = 0, 
    Bool, 
    Int, 
    UInt, 
    Float, 
    Vec2, 
    Vec3, 
    Vec4, 
    Mat3, 
    Mat4,
    IVec2, 
    IVec3, 
    IVec4
}

public interface IShaderUniform
{
    string GetName();
    ShaderUniformType GetType();
    uint GetSize();
    uint GetOffset();
    string UniformTypeToString(ShaderUniformType type);
    void Serialize(StreamWriter serializer, IShaderUniform instance);
    void Deserialize(StreamReader deserializer, IShaderUniform instance);
}