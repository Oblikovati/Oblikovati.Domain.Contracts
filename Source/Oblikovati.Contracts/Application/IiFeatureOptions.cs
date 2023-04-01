namespace Oblikovati.Contracts.Application;

public interface IiFeatureOptions
{
    string RootPath { get; set; }
    string UserRootPath { get; set; }
    string SheetMetalPunchesRootPath { get; set; }
    string Viewer { get; set; }
    string ViewerArguments { get; set; }
    bool UseKey1AsBrowserNameColumn { get; set; }
}