using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILights : IList<ILights>
{


    ILight Item { get; }
    int Count { get; }
    ILight Add(LightTypeEnum LightType);
    IEnumerator GetEnumerator();
}
