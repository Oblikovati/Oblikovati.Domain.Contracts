﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISpellCheckOptions
{

    bool IgnoreCapitalizedWords { get; set; }
    bool IgnoreWordWithMixedCase { get; set; }
    bool IgnoreUppercaseWords { get; set; }
    bool IgnoreWordsWithNumbers { get; set; }
    bool IgnoreWordsContainingPunctuation { get; set; }
    DictionaryLanguageTypeEnum DictionaryLanguage { get; set; }
    ICustomDictionary ActiveCustomDictionary { get; set; }
    ICustomDictionaries CustomDictionaries { get; }
}
