namespace Oblikovati.Domain.Contracts.Rendering;

public struct FramebufferAttachmentSpecification
{
    public FramebufferAttachmentSpecification()
    {
        Attachments = new();
    }
    public FramebufferAttachmentSpecification(IEnumerable<FramebufferTextureSpecification> attachments)
    {
        Attachments = new();
        Attachments.AddRange(attachments);
    }

    List<FramebufferTextureSpecification> Attachments;
};