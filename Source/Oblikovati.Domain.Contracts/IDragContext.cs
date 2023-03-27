namespace Oblikovati.Domain.Contracts;

public interface IDragContext
{
    void Drag(IPoint ModelPosition);
    void StartDrag(IPoint ModelPosition);
    void EndDrag();
    bool TryMove(IMatrix NewPosition);
    void CancelDrag();
}
