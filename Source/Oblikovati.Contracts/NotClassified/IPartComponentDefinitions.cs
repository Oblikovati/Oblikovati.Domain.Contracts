namespace Oblikovati.Contracts.NotClassified;

public interface IPartComponentDefinitions : IList<IPartComponentDefinitions>
{
    IPartComponentDefinition Item { get; }
}