using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IRevisionTables : IList<IRevisionTables>
{
    IRevisionTable Item { get; }


    IRevisionTable Add(IPoint2d PlacementPoint);

    IRevisionTable Add2(IPoint2d PlacementPoint, bool IsSheetScope, bool AutoIndex, bool AlphaIndex, string StartValue,
        object RevisionTableStyle, object Layer);
}