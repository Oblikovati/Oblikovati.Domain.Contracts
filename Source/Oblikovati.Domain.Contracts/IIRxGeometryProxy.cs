namespace Oblikovati.Domain.Contracts;

public interface IIRxGeometryProxy
{
    IntPtr NativeObject { get; }
    IIRxComponentOccurrence ContainingOccurrence { get; }
}
