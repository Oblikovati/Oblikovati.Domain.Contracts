namespace Oblikovati.Domain.Contracts;

public interface IClientNodeResource
{

    IDocument Parent { get; }
    int Id { get; }
    string ClientId { get; }
    string IconName { get; set; }
    string InvisibleIconName { get; set; }
    string SuppressedIconName { get; set; }
    string DisabledIconName { get; set; }
    string ExpandedInvisibleIconName { get; set; }
    string ExpandedSuppressedIconName { get; set; }
    string ExpandedDisabledIconName { get; set; }
    string GroundedIconName { get; set; }
    string GroundedSuppressedIconName { get; set; }
    string GroundedInvisibleIconName { get; set; }
    string GroundedDisabledIconName { get; set; }
    void Delete();
}
