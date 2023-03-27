namespace Oblikovati.Domain.Contracts.Rendering;

public interface IFramebuffer
{
    void Bind();
    void Unbind();
    void Resize(uint width, uint height, bool forceRecreate = false);
    void AddResizeCallback(EventHandler callback);
    void BindTexture(uint attachmentIndex = 0, uint slot = 0);
    uint GetWidth();
    uint GetHeight();
    uint GetRendererID();
    IImage2D GetImage(uint attachmentIndex = 0);
    IImage2D GetDepthImage();
    FramebufferSpecification GetSpecification();
    IFramebuffer Create(FramebufferSpecification spec);
}