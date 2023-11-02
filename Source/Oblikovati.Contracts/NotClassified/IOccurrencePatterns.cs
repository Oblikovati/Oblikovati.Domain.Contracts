using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IOccurrencePatterns : IList<IOccurrencePatterns>
{
    IAssemblyComponentDefinition Parent { get; }

    IOccurrencePattern Item { get; }

    ICircularOccurrencePattern AddCircularPattern(IObjectCollection ParentComponents, object AxisEntity,
        bool AxisEntityNaturalDirection, object AngleOffset, object Count);

    IFeatureBasedOccurrencePattern AddFeatureBasedPattern(IObjectCollection ParentComponents,
        IPartFeature FeaturePattern);

    IRectangularOccurrencePattern AddRectangularPattern(IObjectCollection ParentComponents, object ColumnEntity,
        bool ColumnEntityNaturalDirection, object ColumnOffset, object ColumnCount, object RowEntity,
        bool RowEntityNaturalDirection, object RowOffset, object RowCount);
}