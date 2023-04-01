namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;

public interface IiMateResults : IList<IiMateResults>
{
    IiMateResult Item { get; }


    IiMateResult AddByiMateAndEntity(IiMateDefinition iMateDefinition, object Entity, object EntityBiasPoint,
        object AngleEntityReversed);

    IiMateResult AddByTwoiMates(IiMateDefinition iMateDefinitionOne, IiMateDefinition iMateDefinitionTwo);
}