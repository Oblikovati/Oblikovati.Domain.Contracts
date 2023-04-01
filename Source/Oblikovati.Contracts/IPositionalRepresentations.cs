using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPositionalRepresentations : IList<IPositionalRepresentations>
{
    IPositionalRepresentation Item { get; }
    object ExcelWorkSheet { get; }

    IPositionalRepresentation Add(string Name);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}