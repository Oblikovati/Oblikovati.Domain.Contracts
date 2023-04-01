namespace Oblikovati.Contracts.Application;

public interface ISketch3DOptions : IInjectableSingletonEntity
{
    bool AutoBendWithLineCreation { get; set; }
}