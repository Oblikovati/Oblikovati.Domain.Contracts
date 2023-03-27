namespace Oblikovati.Domain.Contracts;

public interface ISketch3DOptions : IInjectableSingletonEntity
{

    bool AutoBendWithLineCreation { get; set; }
}
