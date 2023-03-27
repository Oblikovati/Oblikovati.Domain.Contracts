namespace Oblikovati.Domain.Contracts;

public interface IContentCenterConfiguration
{

    IDesignProject Parent { get; }
    string ConfigurationXML { get; set; }
    string InheritedConfigurationXML { get; }
    bool UpToDate { get; }
    void Refresh();
}
