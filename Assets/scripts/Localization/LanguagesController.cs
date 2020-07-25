using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguagesController : MonoBehaviour
{
    /*
        1 - Русский
        2 - Английский
        3 - Испанский
        4 - Португальский
        5 - Немецкий
        6 - Французский
        7 - Польский
        8 - Финский
        9 - Шведский
        10 - Норвежский
        11 - Латвийский
        12 - Литовский
        13 - Эстонский
        14 - Корейский
        15 - Японский
        16 - Индийский
        17 - Китайский
      
    */

    private int language;

    private void languageSettings()
    {
        if (Application.systemLanguage == SystemLanguage.Russian)
            language = 1;
        else if (Application.systemLanguage == SystemLanguage.English)
            language = 2;
        else if (Application.systemLanguage == SystemLanguage.Spanish)
            language = 3;
        else if (Application.systemLanguage == SystemLanguage.Portuguese)
            language = 4;
        else if (Application.systemLanguage == SystemLanguage.German)
            language = 5;
        else if (Application.systemLanguage == SystemLanguage.French)
            language = 6;
        else if (Application.systemLanguage == SystemLanguage.Polish)
            language = 7;
        else if (Application.systemLanguage == SystemLanguage.Finnish)
            language = 8;
        else if (Application.systemLanguage == SystemLanguage.Swedish)
            language = 9;
        else if (Application.systemLanguage == SystemLanguage.Norwegian)
            language = 10;
        else if (Application.systemLanguage == SystemLanguage.Latvian)
            language = 11;
        else if (Application.systemLanguage == SystemLanguage.Lithuanian)
            language = 12;
        else if (Application.systemLanguage == SystemLanguage.Estonian)
            language = 13;
        else if (Application.systemLanguage == SystemLanguage.Korean)
            language = 14;
        else if (Application.systemLanguage == SystemLanguage.Japanese)
            language = 15;
        else if (Application.systemLanguage == SystemLanguage.Italian)
            language = 16;
        else
            language = 17;
    }
    
    private void Start()
    {
        languageSettings();
        StaticSettings.languages = language;
    }

}
