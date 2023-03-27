namespace Oblikovati.Domain.Contracts;

public interface IRepresentationsManager
{

    IAssemblyComponentDefinition _Parent { get; }
    IComponentDefinition Parent { get; }
    IPositionalRepresentations PositionalRepresentations { get; }
    IPositionalRepresentation ActivePositionalRepresentation { get; }
    ILevelOfDetailRepresentations LevelOfDetailRepresentations { get; }
    ILevelOfDetailRepresentation ActiveLevelOfDetailRepresentation { get; }
    IDesignViewRepresentations DesignViewRepresentations { get; }
    IDesignViewRepresentation ActiveDesignViewRepresentation { get; }
    string PrivateRepresentationFileName { get; set; }
    bool PrivateRepresentationFileLoaded { get; set; }
}
