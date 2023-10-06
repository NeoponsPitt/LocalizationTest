using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class SceneCtrl : MonoBehaviour
{
    public bool isChanging = false;

    public void ChangeLocale(int index)
    {
        if (isChanging)
            return;

        StartCoroutine(LocaleChange(index));
    }

    IEnumerator LocaleChange(int index)
    {
        isChanging = true;

        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];

        isChanging = false;
    }
}
