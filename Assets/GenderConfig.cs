using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderConfig : MonoBehaviour
{
    public GameObject avatarM;
    public GameObject avatarF;

    void Start()
    {
        //****
        //PlayerPrefs.SetString("UserGender","F");
        //****

        if (PlayerPrefs.GetString("UserGender") == "F")
        {
            avatarF.SetActive(true);
            avatarM.SetActive(false);
        }
        else 
        {
            avatarF.SetActive(false);
            avatarM.SetActive(true);
        }
    }
}
