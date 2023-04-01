using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IBossSets : IList<IBossSets>
{
    IBossSet Item { get; }

    IBossSet Add(IObjectCollection Centers, BossTypeEnum Type, object Diameter, object Offset, object Taper);
}