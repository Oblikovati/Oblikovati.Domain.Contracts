namespace Oblikovati.Contracts.Application;

public interface IOblikovatiVersion
{
    public uint Year {get; }
    public uint Month {get; }
    public uint Day {get; }
    public uint Build { get;  }
}