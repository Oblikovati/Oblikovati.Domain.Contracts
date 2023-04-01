namespace Oblikovati.Contracts.DependencyInjection;

/// <summary>
/// Resolve the dependencies and manages lifecycle.
/// </summary>
public interface IDependencyResolver
{
    T ResolveDepency<T>() where T : IInjectableEntity;

    void RegisterDependency<TIface, TImplementation>(TImplementation cls)
        where TImplementation : class, TIface, new() where TIface : class;
}