using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TriadEventsSink_OnStartMoveEventHandler(TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, IMatrix CoordinateSystem, INameValueMap Context, ref HandlingCodeEnum HandlingCode);
