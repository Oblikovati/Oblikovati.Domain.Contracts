namespace Oblikovati.Domain.Contracts;

public interface ILevelOfDetailRepresentations : IList<ILevelOfDetailRepresentations>
{

    int Count { get; }
    ILevelOfDetailRepresentation Item { get; }
    IEnumerator GetEnumerator();
    ILevelOfDetailRepresentation Add(string Name);
    ILevelOfDetailRepresentation AddSubstitute(string FullFileName, string Name, bool SkipDocumentSave);
}
