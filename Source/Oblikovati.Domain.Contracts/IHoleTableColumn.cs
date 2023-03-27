using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleTableColumn
{

    IHoleTable Parent { get; }
    string Title { get; set; }
    double Width { get; set; }
    HolePropertyEnum PropertyType { get; }
    string CustomPropertyName { get; }
    IUnitsFormatting UnitsFormatting { get; }
    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}
