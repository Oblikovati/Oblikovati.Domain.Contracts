namespace Oblikovati.Contracts.Application.TransientBRep;

public interface ILumpDefinitions : IList<ILumpDefinitions>
{
    ILumpDefinition Item { get; }


    ILumpDefinition Add();
}