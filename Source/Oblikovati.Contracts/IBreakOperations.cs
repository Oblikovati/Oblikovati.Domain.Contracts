using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IBreakOperations : IList<IBreakOperations>
{
    IBreakOperation Item { get; }

    IBreakOperation Add(BreakOrientationEnum Orientation, IPoint2d StartPoint, IPoint2d EndPoint,
        BreakStyleEnum BreakStyle, int DisplayLevel, double Gap, int NumberOfSymbols, bool PropagateToParentView);
}