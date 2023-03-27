using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarSink
{
    void OnApply();
    void OnCancel();
    void OnOK();
    void OnStartMove(INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnMove(INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnEndMove(INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnHide(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnShow(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
