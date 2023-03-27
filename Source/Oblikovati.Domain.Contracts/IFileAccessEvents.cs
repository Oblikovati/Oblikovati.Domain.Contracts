using Oblikovati.Domain.Contracts.DependencyInjection;

namespace Oblikovati.Domain.Contracts;

public interface IFileAccessEvents : IFileAccessEventsSink_Event, IInjectableSingletonEntity
{
}
