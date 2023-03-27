using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TriadEventsSink_OnEndMoveEventHandler(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem, INameValueMap Context, out HandlingCodeEnum HandlingCode);
