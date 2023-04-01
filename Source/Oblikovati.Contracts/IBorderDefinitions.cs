namespace Oblikovati.Contracts;

public interface IBorderDefinitions : IList<IBorderDefinitions>
{
    IBorderDefinition Item { get; }


    IBorderDefinition Add(string Name);
}