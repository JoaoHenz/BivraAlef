using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
using System.Text.RegularExpressions;

public class ButtonScripts : MonoBehaviour
{
    string thisPath = Application.streamingAssetsPath + "/";
    public string fileName = "test";
    private string ext = ".txt";

    public int currentIdentifier = 0;
    private GameObject SelectionUI;

    private void Start()
    {
#if UNITY_ANDROID
            thisPath = Application.persistentDataPath + "/";
#endif
#if UNITY_EDITOR
            thisPath = Application.streamingAssetsPath + "/";
#endif
#if UNITY_STANDALONE
            thisPath = Application.streamingAssetsPath + "/";
#endif

        SelectionUI = GameObject.Find("SelectionUI");
        if (SelectionUI != null)
        {
            SelectionUI.SetActive(false);
        }
    }

    public void SelectIdentifier(int idNumber)
    {
        currentIdentifier = idNumber;

        SelectionUI.SetActive(true);
        PositionUI(SelectionUI, currentIdentifier);

        //Debug.Log(currentIdentifier);

    }

    public void SetFileName()
    {
        GameObject inputField = GameObject.Find("UserID");
        string inputText = inputField.GetComponent<InputField>().text;

        if (inputText != "")
        {
            fileName = Path.Combine(thisPath, (inputText + ext));
            File.WriteAllText(fileName, "");
        }
        else
        {
            fileName = CreateNewUserFile(thisPath);
        }
        PlayerPrefs.SetString("CurrentID", fileName);

        PlayerPrefs.SetString("PlayerScores", "");

        //Debug.Log("Input text: " + fileName);
    }

    public void WriteToFile()
    {
        Debug.Log(SceneManager.GetActiveScene().name.ToString());

        string filePath = PlayerPrefs.GetString("CurrentID");
        File.AppendAllText(filePath, currentIdentifier.ToString() + " \n");

        PlayerPrefs.SetString("PlayerScores", PlayerPrefs.GetString("PlayerScores") + currentIdentifier.ToString() + " ");


    }

    public void CancelSelection()
    {
        SelectionUI.SetActive(false);
        currentIdentifier = 0;
    }

    private void PositionUI(GameObject ObjectUI, int AvatarNumber)
    {
        if (SceneManager.GetActiveScene().name == "Practice")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                rectTransform.localPosition = new Vector3(6f, 3f, -0.5f);
                rectTransform.localRotation = Quaternion.Euler(0f, 270f, 0f);
            }
            else if (currentIdentifier == 2)
            {
                rectTransform.localPosition = new Vector3(6f, 3f, 3.5f);
                rectTransform.localRotation = Quaternion.Euler(0f, 270f, 0f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females1")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 2);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females2")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 1);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females3")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 8);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females4")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 2);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females5")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 7);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females1b")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 6);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females2b")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 1);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females3b")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 7);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 3);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females4b")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 7);
            }
        }

        if (SceneManager.GetActiveScene().name == "Females5b")
        {
            RectTransform rectTransform = ObjectUI.GetComponent<RectTransform>();
            if (currentIdentifier == 1)
            {
                ArrangementUI(rectTransform, 8);
            }
            else if (currentIdentifier == 2)
            {
                ArrangementUI(rectTransform, 1);
            }
            else if (currentIdentifier == 3)
            {
                ArrangementUI(rectTransform, 2);
            }
            else if (currentIdentifier == 4)
            {
                ArrangementUI(rectTransform, 3);
            }
            else if (currentIdentifier == 5)
            {
                ArrangementUI(rectTransform, 4);
            }
            else if (currentIdentifier == 6)
            {
                ArrangementUI(rectTransform, 5);
            }
            else if (currentIdentifier == 7)
            {
                ArrangementUI(rectTransform, 6);
            }
            else if (currentIdentifier == 8)
            {
                ArrangementUI(rectTransform, 7);
            }
        }

    }

    private void ArrangementUI(RectTransform rectTransform, int order)
    {
        //  Positions
        //  *   *   7   *   * 
        //  *   6   *   8   *
        //  5   *   *   *   1
        //  *   4   *   2   *
        //  *   *   3   *   *

        if (order == 1)
        {
            rectTransform.localPosition = new Vector3(0f, 4f, -6f);
            rectTransform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (order == 2)
        {
            rectTransform.localPosition = new Vector3(-3.5f, 4f, -4.5f);
            rectTransform.localRotation = Quaternion.Euler(0f, 45f, 0f);
        }
        else if (order == 3)
        {
            rectTransform.localPosition = new Vector3(-5f, 4f, 0f);
            rectTransform.localRotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else if (order == 4)
        {
            rectTransform.localPosition = new Vector3(-3.5f, 4f, 4.5f);
            rectTransform.localRotation = Quaternion.Euler(0f, 135f, 0f);
        }
        else if (order == 5)
        {
            rectTransform.localPosition = new Vector3(0f, 4f, 6f);
            rectTransform.localRotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (order == 6)
        {
            rectTransform.localPosition = new Vector3(3.5f, 4f, 4.5f);
            rectTransform.localRotation = Quaternion.Euler(0f, 225f, 0f);
        }
        else if (order == 7)
        {
            rectTransform.localPosition = new Vector3(5f, 4f, 0f);
            rectTransform.localRotation = Quaternion.Euler(0f, 270f, 0f);
        }
        else if (order == 8)
        {
            rectTransform.localPosition = new Vector3(3.5f, 4f, -4.5f);
            rectTransform.localRotation = Quaternion.Euler(0f, 315f, 0f);
        }
    }

    private static int GetNextAvailableUserNumber(string folderPath)
    {
        string[] files = Directory.GetFiles(folderPath, "P*.txt");
        Regex regex = new Regex(@"P(\d{5})\.txt");
        var usedNumbers = files
            .Select(file => regex.Match(Path.GetFileName(file)))
            .Where(match => match.Success)
            .Select(match => int.Parse(match.Groups[1].Value))
            .OrderBy(num => num)
            .ToList();
        int availableNumber = 1;
        foreach (int usedNumber in usedNumbers)
        {
            if (availableNumber == usedNumber)
            {
                availableNumber++;
            }
            else
            {
                break;
            }
        }
        return availableNumber;
    }

    private static string CreateNewUserFile(string folderPath)
    {
        int nextNumber = GetNextAvailableUserNumber(folderPath);
        string fileName = $"P{nextNumber:D5}.txt";
        string fullPath = Path.Combine(folderPath, fileName);
        File.WriteAllText(fullPath, "");
        return fullPath;
    }

    public void QuitApp()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif    
    }
}
