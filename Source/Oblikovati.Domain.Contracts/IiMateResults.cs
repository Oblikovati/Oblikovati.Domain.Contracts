namespace Oblikovati.Domain.Contracts;

public interface IiMateResults : IList<IiMateResults>
{

    IiMateResult Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IiMateResult AddByiMateAndEntity(IiMateDefinition iMateDefinition, object Entity, object EntityBiasPoint, object AngleEntityReversed);
    IiMateResult AddByTwoiMates(IiMateDefinition iMateDefinitionOne, IiMateDefinition iMateDefinitionTwo);
}
