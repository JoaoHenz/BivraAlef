using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScriptToChangeScene : MonoBehaviour
{
    public void ChangeScene (string sceneName)
    {
        Application.LoadLevel(sceneName);
        //Debug.Log(sceneName);
    }
}
