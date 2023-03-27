namespace Oblikovati.Domain.Contracts;

public interface IRadialMarkingMenu
{
    object EastControl { get; set; }
    object NorthControl { get; set; }
    object NortheastControl { get; set; }
    object NorthwestControl { get; set; }
    object SouthControl { get; set; }
    object SoutheastControl { get; set; }
    object SouthwestControl { get; set; }
    object WestControl { get; set; }
    bool BuiltIn { get; }
    string ClientId { get; }
    string InternalName { get; }
    string Name { get; set; }
    IRadialMarkingMenu CreateRadialSubMenu(string Name);
    void Delete();
    void Clear();
}
