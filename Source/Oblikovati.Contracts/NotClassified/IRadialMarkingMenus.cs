namespace Oblikovati.Contracts.NotClassified;

public interface IRadialMarkingMenus : IList<IRadialMarkingMenus>
{
    IRadialMarkingMenu Item { get; }

    IRadialMarkingMenu Add(string Name, string InternalName, string ClientId);
}