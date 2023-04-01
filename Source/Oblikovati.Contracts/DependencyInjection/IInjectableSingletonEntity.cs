namespace Oblikovati.Contracts.DependencyInjection;

/// <summary>
/// Represents injectable entities that have singleton lifecycle.
/// </summary>
public interface IInjectableSingletonEntity : IInjectableEntity, IDisposable
{
}