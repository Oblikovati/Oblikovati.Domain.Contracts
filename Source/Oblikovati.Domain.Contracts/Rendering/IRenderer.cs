using System.Numerics;

namespace Oblikovati.Domain.Contracts.Rendering;

public interface IRenderer
{
    void Init();
    void Shutdown();
    IShaderLibrary GetShaderLibrary();
    void Submit();
    void SubmitResourceFree();
    void WaitAndRender();
    void BeginRenderPass(IRenderCommandBuffer renderCommandBuffer, IRenderPass renderPass, bool explicitClear = false);
    void EndRenderPass(IRenderCommandBuffer renderCommandBuffer);
    void RT_BeginGPUPerfMarker(IRenderCommandBuffer renderCommandBuffer, string label, Vector4 markerColor = default);
    void RT_InsertGPUPerfMarker(IRenderCommandBuffer renderCommandBuffer, string label, Vector4 markerColor = default);
    void RT_EndGPUPerfMarker(IRenderCommandBuffer renderCommandBuffer);
    void BeginFrame();
    void EndFrame();
    void SetSceneEnvironment(ISceneRenderer sceneRenderer, IRenderEnvironment environment, IImage2D shadow);
    Tuple<ITextureCube, ITextureCube> CreateEnvironmentMap(string filepath);
    ITextureCube CreatePreethamSky(float turbidity, float azimuth, float inclination);
    void RenderStaticMesh(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, 
    IStaticMesh mesh, uint submeshIndex, IMaterialTable materialTable, 
    IVertexBuffer transformBuffer, uint transformOffset, uint instanceCount);
    void RenderSubmesh(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IMesh mesh,
    uint submeshIndex, IMaterialTable materialTable, Matrix4x4 transform);
    void RenderSubmeshInstanced(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IMesh mesh, 
    uint submeshIndex, IMaterialTable materialTable, IVertexBuffer transformBuffer, 
    uint transformOffset, uint instanceCount);
    void RenderMeshWithMaterial(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IMesh mesh, 
    uint submeshIndex, IVertexBuffer transformBuffer, uint transformOffset, 
    uint instanceCount, IMaterial material, object additionalUniforms = default);
    void RenderStaticMeshWithMaterial(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IStaticMesh mesh, 
    uint submeshIndex, IVertexBuffer transformBuffer, uint transformOffset, 
    uint instanceCount, IMaterial material, object additionalUniforms = default);
    void RenderQuad(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IMaterial material,
    Matrix4x4 transform);
    void SubmitFullscreenQuad(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IMaterial material);
    void SubmitFullscreenQuad(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, 
    IMaterial material);
    void SubmitFullscreenQuadWithOverrides(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline,
    IUniformBufferSet uniformBufferSet, IMaterial material, 
    object vertexShaderOverrides, object fragmentShaderOverrides);
    void LightCulling(IRenderCommandBuffer renderCommandBuffer, IPipelineCompute computePipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, IMaterial material,
    Vector3 workGroups);
    void DispatchComputeShader(IRenderCommandBuffer renderCommandBuffer, 
    IPipelineCompute computePipeline, IUniformBufferSet uniformBufferSet, 
    IStorageBufferSet storageBufferSet, IMaterial material, Vector3 workGroups, 
    object additionalUniforms = default);
    void RenderGeometry(IRenderCommandBuffer renderCommandBuffer, IPipeline pipeline, 
    IUniformBufferSet uniformBufferSet, IStorageBufferSet storageBufferSet, 
    IMaterial material, IVertexBuffer vertexBuffer, IIndexBuffer indexBuffer,
    Matrix4x4 transform, uint indexCount = 0);
    void SubmitQuad(IRenderCommandBuffer renderCommandBuffer, IMaterial material,
    Matrix4x4 transform = default);
    void ClearImage(IRenderCommandBuffer renderCommandBuffer, IImage2D image);
    ITexture2D GetWhiteTexture();
    ITexture2D GetBlackTexture();
    ITexture2D GetHilbertLut();
    ITexture2D GetBRDFLutTexture();
    ITextureCube GetBlackCubeTexture();
    IRenderEnvironment GetEmptyEnvironment();
    void RegisterShaderDependency(IShader shader, IPipelineCompute computePipeline);
    void RegisterShaderDependency(IShader shader, IPipeline pipeline);
    void RegisterShaderDependency(IShader shader, IMaterial material);
    void OnShaderReloaded(long hash);
    uint GetCurrentFrameIndex();
    RendererConfig GetConfig();
    void SetConfig(RendererConfig config);
    IRenderCommandQueue GetRenderResourceReleaseQueue(uint index);
    Dictionary<string, string> GetGlobalShaderMacros();
    void AcknowledgeParsedGlobalMacros(IEnumerable<string> macros, IShader shader);
    void SetMacroInShader(IShader shader, string name, string value = "");
    void SetGlobalMacroInShaders(string name, string value = "");
    bool UpdateDirtyShaders();
}