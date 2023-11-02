using Oblikovati.Contracts.Application.ApplicationAddIns;
using Oblikovati.Contracts.Application.DesignProjectManager;
using Oblikovati.Contracts.Application.DisplayOptions;
using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Application.HelpManager;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application;

public interface IApplicationBase
{
    IApplicationLog Log { get; }
    public IFileLocations FileLocations { get; }
    public IApplicationAddIns ApplicationAddIns { get; }
    public ISoftwareVersion SoftwareVersion { get; }
    public string UserName { get; }
    public ITransientGeometry TransientGeometry { get; }
    public IFileManager FileManager { get; }
    public IFileOptions FileOptions { get; }
    public int Locale { get; }
    public IDisplayOptions DisplayOptions { get; }
    public IHardwareOptions HardwareOptions { get; }
    public string InstallPath { get; }
    public IDesignProjectManager DesignProjectManager { get; }
    public string CurrentUserAppDataPath { get; }
    public string AllUsersAppDataPath { get; }
    public ITransientObjects TransientObjects { get; }
    public IFileAccessEvents FileAccessEvents { get; }
    public IReferenceKeyEvents ReferenceKeyEvents { get; }
    public ITestManager TestManager { get; }
    public IHelpManager HelpManager { get; }
    IDependencyResolver GetDependencyResolver();
    void Run();
    void Shutdown();
}