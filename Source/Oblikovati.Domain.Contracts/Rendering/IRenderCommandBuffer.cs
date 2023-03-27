namespace Oblikovati.Domain.Contracts.Rendering;

public interface IRenderCommandBuffer
{
    void Begin();
	void End();
	void Submit();
    float GetExecutionGPUTime( uint frameIndex, uint queryIndex = 0);
    PipelineStatistics GetPipelineStatistics(uint frameIndex);
	uint BeginTimestampQuery();
	void EndTimestampQuery(uint queryID);
	IRenderCommandBuffer Create(uint count = 0, string debugName = "");
	IRenderCommandBuffer CreateFromSwapChain(string debugName = "");
}