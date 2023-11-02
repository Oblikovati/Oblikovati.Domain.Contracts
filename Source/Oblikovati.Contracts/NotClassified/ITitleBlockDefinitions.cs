namespace Oblikovati.Contracts.NotClassified;

public interface ITitleBlockDefinitions : IList<ITitleBlockDefinitions>
{
    ITitleBlockDefinition Item { get; }


    ITitleBlockDefinition Add(string Name);
}