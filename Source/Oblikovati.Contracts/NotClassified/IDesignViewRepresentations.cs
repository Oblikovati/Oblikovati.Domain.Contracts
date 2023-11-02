namespace Oblikovati.Contracts.NotClassified;

public interface IDesignViewRepresentations : IList<IDesignViewRepresentations>
{
    IDesignViewRepresentation Item { get; }

    IDesignViewRepresentation Add(string Name, bool Reserved);
}