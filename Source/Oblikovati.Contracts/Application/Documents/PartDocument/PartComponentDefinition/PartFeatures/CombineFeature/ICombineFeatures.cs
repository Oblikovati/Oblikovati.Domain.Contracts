using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CombineFeature;

public interface ICombineFeatures : IList<ICombineFeatures>
{
    ICombineFeature Item { get; }


    ICombineFeature Add(ISurfaceBody BaseBody, IObjectCollection ToolBodies, PartFeatureOperationEnum Operation,
        bool KeepToolBodies);
}