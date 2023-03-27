namespace Oblikovati.Domain.Contracts.Rendering;

public struct RendererConfig
{
	uint FramesInFlight;
	bool ComputeEnvironmentMaps;
	uint EnvironmentMapResolution;
	uint IrradianceMapComputeSamples;
	string ShaderPackPath;

    public RendererConfig()
    {
        FramesInFlight = 3;
        ComputeEnvironmentMaps = true;
        EnvironmentMapResolution = 1024;
        IrradianceMapComputeSamples = 512;
        ShaderPackPath = "";
    }
}