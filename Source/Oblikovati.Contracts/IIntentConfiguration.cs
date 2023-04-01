using Oblikovati.Contracts.Application.DesignProjectManager;

namespace Oblikovati.Contracts;

public interface IIntentConfiguration
{
    IDesignProject Parent { get; }
    string ConfigurationXML { get; set; }
    string InheritedConfigurationXML { get; }
    bool UpToDate { get; }
    void Refresh();
}