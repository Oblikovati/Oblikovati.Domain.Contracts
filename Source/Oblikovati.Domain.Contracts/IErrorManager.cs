﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IErrorManager
{


    string AllMessages { get; }
    bool HasErrors { get; }
    bool HasWarnings { get; }
    bool IsMessageSectionActive { get; }
    string LastMessage { get; }
    void AddMessage(string Message, bool Error, object Reserved);
    void Clear();
    ButtonTypeEnum Show(string Title, bool AllowAccept, bool AllowEdit);
    IMessageSection StartMessageSection();
}
