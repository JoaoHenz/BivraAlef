using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using UnityEngine.InputSystem;

public class SettingScript : MonoBehaviour
{
    private bool currentGender; // 1->F 0->M

    public GameObject SelectM;
    public GameObject SelectF;

    void Start()
    {
        currentGender = true;
    }

    void Update()
    {
        if (SelectF.GetComponent<Toggle>().isOn)
        {
            currentGender = true;
        }
        else if (SelectM.GetComponent<Toggle>().isOn)
        {
            currentGender = false;
        }
        else
        {
            if (currentGender)
                SelectF.GetComponent<Toggle>().isOn = true;
            else
                SelectM.GetComponent<Toggle>().isOn = true;
        }
    }

    public void SetGender()
    {
        if (currentGender)
        {
            PlayerPrefs.SetString("UserGender", "F");
        }
        else
        {
            PlayerPrefs.SetString("UserGender", "M");
        }
    }
}