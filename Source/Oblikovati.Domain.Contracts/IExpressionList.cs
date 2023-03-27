namespace Oblikovati.Domain.Contracts;

public interface IExpressionList : IList<IExpressionList>
{

    IParameter Parent { get; }
    int Count { get; }
    string Item { get; }
    bool AllowCustomValues { get; set; }
    IEnumerator GetEnumerator();
    void ClearAll();
    List<string> GetExpressionList();
    void SetExpressionList(List<string> ExpressionList, bool ChangeCurrentValue, int CurrentValueIndex);
}
