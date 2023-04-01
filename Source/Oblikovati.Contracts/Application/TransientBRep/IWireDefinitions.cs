namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IWireDefinitions : IList<IWireDefinitions>
{
    IWireDefinition Item { get; }


    IWireDefinition Add();
}