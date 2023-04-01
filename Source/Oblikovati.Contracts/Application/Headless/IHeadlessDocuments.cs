namespace Oblikovati.Contracts.Application.Headless;

public interface IHeadlessDocuments : IList<IHeadlessDocuments>
{
    IHeadlessDocument Item { get; }
}