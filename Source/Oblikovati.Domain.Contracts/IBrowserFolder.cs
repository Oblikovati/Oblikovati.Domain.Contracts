namespace Oblikovati.Domain.Contracts;

public interface IBrowserFolder
{


    IBrowserNode BrowserNode { get; }
    string Name { get; set; }
    bool AllowAddRemove { get; set; }
    bool AllowDelete { get; set; }
    bool AllowRename { get; set; }
    bool AllowReorder { get; set; }
    void Add(IBrowserNode BrowserNode, object TargetNode, bool Before);
    void Delete(bool Reserved);
    void Remove(IBrowserNode BrowserNode, object TargetNode, bool Before);
    void SetEndOfPart(bool Before);
}
