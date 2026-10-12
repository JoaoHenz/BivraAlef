using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Localization.Settings;

public class LocalizationManager : MonoBehaviour
{
    void Start()
    {
        int ID = PlayerPrefs.GetInt("LocaleKey",0);
        ChangeLocale(ID);
    }

    public void ChangeLocale(int LocaleID)
    {
        LocalizationSettings.InitializationOperation.WaitForCompletion();
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[LocaleID];
        PlayerPrefs.SetInt("LocaleKey", LocaleID);
    }
}
