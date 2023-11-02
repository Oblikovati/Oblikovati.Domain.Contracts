namespace Oblikovati.Contracts.NotClassified;

public interface ILevelOfDetailRepresentations : IList<ILevelOfDetailRepresentations>
{
    ILevelOfDetailRepresentation Item { get; }

    ILevelOfDetailRepresentation Add(string Name);
    ILevelOfDetailRepresentation AddSubstitute(string FullFileName, string Name, bool SkipDocumentSave);
}