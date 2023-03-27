namespace Oblikovati.Domain.Contracts;

public interface IDesignViewRepresentations : IList<IDesignViewRepresentations>
{

    int Count { get; }
    IDesignViewRepresentation Item { get; }
    IEnumerator GetEnumerator();
    IDesignViewRepresentation Add(string Name, bool Reserved);
}
