using Oblikovati.Contracts.Application.DesignProjectManager;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentCenterConfiguration
{
    IDesignProject Parent { get; }
    string ConfigurationXML { get; set; }
    string InheritedConfigurationXML { get; }
    bool UpToDate { get; }
    void Refresh();
}