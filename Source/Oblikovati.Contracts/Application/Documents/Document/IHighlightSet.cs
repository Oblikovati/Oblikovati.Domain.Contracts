using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IHighlightSet : IList<IHighlightSet>
{
    object Item { get; }
    IColor Color { get; set; }
    void Remove(object Index);
    void Delete();
    void AddItem(object Entity);
    void GetColor(out int Red, out int Green, out int Blue);
    void SetColor(int Red, int Green, int Blue);

    void AddMultipleItems(IObjectCollection Entities);
}