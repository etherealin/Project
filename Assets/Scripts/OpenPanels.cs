using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPanel1 : MonoBehaviour
{
    public GameObject play;
    public GameObject settings;

    public void StartPlay()
    {
        play.SetActive(!play.activeSelf);
    }
    public void StartSettigs()
    {
        settings.SetActive(!play.activeSelf);
    }

    public void ExitPlay()
    {
        play.SetActive(false);
    }

    public void ExitSettings()
    {
        settings.SetActive(false);
    }
}
