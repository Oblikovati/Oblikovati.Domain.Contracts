namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingHatchPatternsManager : IList<IDrawingHatchPatternsManager>
{
    IDrawingHatchPattern Item { get; }
    IDrawingDocument Parent { get; }

    void ExportHatchPatterns(object DrawingHatchPatterns, string FullFileName);

    void GetHatchPatternDefinitions(string FullFileName, out List<string> PatternDefinitionNames,
        out List<string> Descriptions);

    void LoadHatchPatterns(string FullFileName, List<string> PatternDefinitionNames);
}