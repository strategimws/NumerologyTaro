using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationController : MonoBehaviour
{
    [SerializeField]
    private string[] translateText;
    [SerializeField]
    private Text textLanguage;

    private int localization;


    private void translating()
    {
        localization = StaticSettings.languages;
        switch (localization)
        {
            case 1: textLanguage.text = translateText[localization - 1]; break;
            case 2: textLanguage.text = translateText[localization - 1]; break;
            case 3: textLanguage.text = translateText[localization - 1]; break;
            case 4: textLanguage.text = translateText[localization - 1]; break;
            case 5: textLanguage.text = translateText[localization - 1]; break;
            case 6: textLanguage.text = translateText[localization - 1]; break;
            case 7: textLanguage.text = translateText[localization - 1]; break;
            case 8: textLanguage.text = translateText[localization - 1]; break;
            case 9: textLanguage.text = translateText[localization - 1]; break;
            case 10: textLanguage.text = translateText[localization - 1]; break;
            case 11: textLanguage.text = translateText[localization - 1]; break;
            case 12: textLanguage.text = translateText[localization - 1]; break;
            case 13: textLanguage.text = translateText[localization - 1]; break;
            case 14: textLanguage.text = translateText[localization - 1]; break;
            case 15: textLanguage.text = translateText[localization - 1]; break;
            case 16: textLanguage.text = translateText[localization - 1]; break;
            default: textLanguage.text = translateText[1]; break;
        }
    }

    private void Start()
    {
        translating();
    }
}
