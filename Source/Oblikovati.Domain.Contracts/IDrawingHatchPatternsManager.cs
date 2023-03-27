namespace Oblikovati.Domain.Contracts;

public interface IDrawingHatchPatternsManager : IList<IDrawingHatchPatternsManager>
{

    int Count { get; }
    IDrawingHatchPattern Item { get; }
    I_DrawingDocument Parent { get; }
    IEnumerator GetEnumerator();
    void ExportHatchPatterns(object DrawingHatchPatterns, string FullFileName);
    void GetHatchPatternDefinitions(string FullFileName, out List<string> PatternDefinitionNames, out List<string> Descriptions);
    void LoadHatchPatterns(string FullFileName, List<string> PatternDefinitionNames);
}
