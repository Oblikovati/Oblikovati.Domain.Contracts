using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IFileDialogEventsSink_Event
{
    void add_OnOptions(FileDialogEventsSink_OnOptionsEventHandler handler);
    void remove_OnOptions(FileDialogEventsSink_OnOptionsEventHandler handler);
}
