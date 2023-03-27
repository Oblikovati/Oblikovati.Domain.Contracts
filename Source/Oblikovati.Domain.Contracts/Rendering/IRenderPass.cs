namespace Oblikovati.Domain.Contracts.Rendering;

public interface IRenderPass
{
    public RenderPassSpecification GetSpecification();
    public IRenderPass Create(RenderPassSpecification spec);
}