using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TriadEventsSink_OnMoveEventHandler(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem, INameValueMap Context, ref HandlingCodeEnum HandlingCode);
