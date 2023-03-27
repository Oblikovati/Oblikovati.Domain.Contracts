using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnContextualMiniToolbarEventHandler(IObjectsEnumerator SelectedEntities, INameValueMap DisplayedCommands, INameValueMap AdditionalInfo);
