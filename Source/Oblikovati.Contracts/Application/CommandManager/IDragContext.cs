using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Application.CommandManager;

public interface IDragContext
{
    void Drag(IPoint ModelPosition);
    void StartDrag(IPoint ModelPosition);
    void EndDrag();
    bool TryMove(IMatrix NewPosition);
    void CancelDrag();
}