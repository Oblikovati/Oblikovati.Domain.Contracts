namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface ISketchBlockDefinitions : IList<ISketchBlockDefinitions>
{
    ISketchBlockDefinition Item { get; }


    ISketchBlockDefinition Add(string Name, object InsertionPoint);
}