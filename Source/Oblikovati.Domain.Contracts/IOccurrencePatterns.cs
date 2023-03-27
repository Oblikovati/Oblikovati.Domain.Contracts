namespace Oblikovati.Domain.Contracts;

public interface IOccurrencePatterns : IList<IOccurrencePatterns>
{

    IAssemblyComponentDefinition Parent { get; }
    int Count { get; }
    IOccurrencePattern Item { get; }
    ICircularOccurrencePattern AddCircularPattern(IObjectCollection ParentComponents, object AxisEntity, bool AxisEntityNaturalDirection, object AngleOffset, object Count);
    IFeatureBasedOccurrencePattern AddFeatureBasedPattern(IObjectCollection ParentComponents, IPartFeature FeaturePattern);
    IRectangularOccurrencePattern AddRectangularPattern(IObjectCollection ParentComponents, object ColumnEntity, bool ColumnEntityNaturalDirection, object ColumnOffset, object ColumnCount, object RowEntity, bool RowEntityNaturalDirection, object RowOffset, object RowCount);
    IEnumerator GetEnumerator();
}
