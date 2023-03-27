using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPositionalRepresentations : IList<IPositionalRepresentations>
{

    int Count { get; }
    IPositionalRepresentation Item { get; }
    object ExcelWorkSheet { get; }
    IEnumerator GetEnumerator();
    IPositionalRepresentation Add(string Name);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}
