namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;

public interface IUnfoldMethods : IList<IUnfoldMethods>
{
    IUnfoldMethod Item { get; }


    IUnfoldMethod AddLinearUnfoldMethod(string Name, string Value);
    IUnfoldMethod AddBendTableFromFile(string Name, string FileName);
    IUnfoldMethod AddEquationUnfoldMethod(string Name);
}