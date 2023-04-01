using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface ITriadEventsSink
{
    void OnActivate(INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnEndMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnEndSequence(bool Cancelled, IMatrix CoordinateSystem, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnStartSequence(IMatrix CoordinateSystem, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnMoveTriadOnlyToggle(bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnStartMove(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnTerminate(bool Cancelled, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnSegmentSelectionChange(TriadSegmentEnum SelectedTriadSegment, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnEndSequence2(bool Cancelled, IMatrix CoordinateSystem, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnTerminate2(bool Cancelled, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnMoveTriadOnlyToggle2(bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}