using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiMateDefinitions : IList<IiMateDefinitions>
{

    IiMateDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IAngleiMateDefinition AddAngleiMateDefinition(object Entity, bool DirectionReversed, object Angle, object BiasPoint, string Name, object MatchList);
    ICompositeiMateDefinition AddCompositeiMateDefinition(IObjectCollection iMates, string Name, object MatchList);
    IFlushiMateDefinition AddFlushiMateDefinition(object Entity, object Offset, object BiasPoint, string Name, object MatchList);
    IMateiMateDefinition AddMateiMateDefinition(object Entity, object Offset, InferredTypeEnum EntityInferredType, object BiasPoint, string Name, object MatchList);
    IInsertiMateDefinition AddInsertiMateDefinition(object Entity, bool AxesOpposed, object Distance, object BiasPoint, string Name, object MatchList);
    IRotateRotateiMateDefinition AddRotateRotateiMateDefinition(object Entity, object Ratio, bool ForwardDirection, object BiasPoint, string Name, object MatchList);
    IRotateTranslateiMateDefinition AddRotateTranslateiMateDefinition(object Entity, object Ratio, bool ForwardDirection, object BiasPoint, string Name, object MatchList);
    ITangentiMateDefinition AddTangentiMateDefinition(object Entity, bool InsideTangency, object Offset, object BiasPoint, string Name, object MatchList);
}
