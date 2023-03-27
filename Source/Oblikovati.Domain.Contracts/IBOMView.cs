using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBOMView
{

    IBOM Parent { get; }
    string RevisionId { get; }
    string Name { get; }
    IBOMRowsEnumerator BOMRows { get; }
    BOMViewTypeEnum ViewType { get; }
    string iAssemblyMemberName { get; set; }
    string ModelStateMemberName { get; }
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
    void Renumber(int StartValue, int Increment, object BOMRowsToRenumber);
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle, bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending);
    void Sort2(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle, bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending, bool SortByString);
}
