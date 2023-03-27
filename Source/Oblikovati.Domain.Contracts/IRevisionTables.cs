namespace Oblikovati.Domain.Contracts;

public interface IRevisionTables : IList<IRevisionTables>
{

    IRevisionTable Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRevisionTable Add(IPoint2d PlacementPoint);
    IRevisionTable Add2(IPoint2d PlacementPoint, bool IsSheetScope, bool AutoIndex, bool AlphaIndex, string StartValue, object RevisionTableStyle, object Layer);
}
