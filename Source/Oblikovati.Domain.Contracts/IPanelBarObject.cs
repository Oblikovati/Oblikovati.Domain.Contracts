﻿namespace Oblikovati.Domain.Contracts;

public interface IPanelBarObject
{
    IEnvironment Parent { get; }
    ICommandBar DefaultCommandBar { get; set; }
    ICommandBar CurrentCommandBar { get; set; }
    ICommandBarList CommandBarList { get; }
}
