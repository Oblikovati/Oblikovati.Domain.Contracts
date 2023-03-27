using Oblikovati.Domain.Contracts.Application;

namespace Oblikovati.Domain.Contracts;

public interface IVbaApplication
{
    IApplication ThisApplication { get; }
    IOblikovatiServer ThisServer { get; }
}
