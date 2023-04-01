namespace Oblikovati.Contracts.Parameters;

public interface IExpressionList : IList<IExpressionList>
{
    IParameter Parent { get; }

    string Item { get; }
    bool AllowCustomValues { get; set; }

    void ClearAll();
    List<string> GetExpressionList();
    void SetExpressionList(List<string> ExpressionList, bool ChangeCurrentValue, int CurrentValueIndex);
}