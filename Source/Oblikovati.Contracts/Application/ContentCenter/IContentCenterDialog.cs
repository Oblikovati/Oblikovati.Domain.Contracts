using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentCenterDialog
{
    string DialogTitle { get; set; }
    string DisplayFilter { get; set; }
    string CurrentSelection { get; set; }
    ContentItemTypeEnum SelectionType { get; set; }
    bool MultiSelect { get; set; }
    bool ApplyButton { get; set; }
    bool CancelButton { get; set; }
    bool OKButton { get; set; }
    string ApplyButtonString { get; set; }
    string CancelButtonString { get; set; }
    string OKButtonString { get; set; }
    string DisplayActiveLibrary { get; set; }
    bool Visible { get; set; }
    DialogStyleEnum Style { get; set; }
    IContentCenterDialogEvents ContentCenterDialogEvents { get; }
    bool ApplyButtonEnabled { get; set; }
    bool CancelButtonEnabled { get; set; }
    bool OKButtonEnabled { get; set; }
    void SetCheckBoxOptions(INameValueMap Context);
    void Show(bool Modal);
    void Terminate();
}