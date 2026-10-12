using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Text loadingText; 
    private int dotCount = 1;
    private bool increasing = true;

    void Start()
    {
        StartCoroutine(DotCycle());
    }

    IEnumerator DotCycle()
    {
        while (true)
        {
            loadingText.text = new string('.', dotCount);
            if (increasing)
            {
                dotCount += 2;
                if (dotCount > 10) increasing = false;
            }
            else
            {
                dotCount -= 2;
                if (dotCount <= 1) increasing = true;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
