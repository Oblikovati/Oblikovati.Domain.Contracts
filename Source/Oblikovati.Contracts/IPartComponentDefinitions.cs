namespace Oblikovati.Contracts;

public interface IPartComponentDefinitions : IList<IPartComponentDefinitions>
{
    IPartComponentDefinition Item { get; }
}