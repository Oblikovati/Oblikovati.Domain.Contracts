using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBreakOperations : IList<IBreakOperations>
{

    int Count { get; }
    IBreakOperation Item { get; }
    IBreakOperation Add(BreakOrientationEnum Orientation, IPoint2d StartPoint, IPoint2d EndPoint, BreakStyleEnum BreakStyle, int DisplayLevel, double Gap, int NumberOfSymbols, bool PropagateToParentView);
    IEnumerator GetEnumerator();
}
