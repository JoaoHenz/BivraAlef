using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResults : MonoBehaviour
{

    public GameObject TextSelected;
    public GameObject TextMean;

    private int[] ScoreTask1=new int[5];
    private int[] ScoreTask2 = new int[5];
    private float[] ScoreTask3 = new float[4];

    void Start()
    {

        Debug.Log(PlayerPrefs.GetString("PlayerScores"));

        string scores = PlayerPrefs.GetString("PlayerScores");

        float[] AllScores = ConvertStringToFloatArray(scores);

        string Scores1 = AllScores[0].ToString() + ", " + AllScores[1].ToString() + ", " + AllScores[2].ToString() + ", " + AllScores[3].ToString() + ", " + AllScores[4].ToString();
        string Scores2 = AllScores[5].ToString() + ", " + AllScores[6].ToString() + ", " + AllScores[7].ToString() + ", " + AllScores[8].ToString() + ", " + AllScores[9].ToString();
        string Scores3 = AllScores[10].ToString("F2") + ", " + AllScores[11].ToString("F2") + ", " + AllScores[12].ToString("F2") + ", " + AllScores[13].ToString("F2");

        TextSelected.GetComponent<Text>().text = Scores1 + "\n\n" + Scores2 + "\n\n" + Scores3;


        float MeanBMI1 = (ConvertToBMI(AllScores[0]) + ConvertToBMI(AllScores[1]) + ConvertToBMI(AllScores[2]) + ConvertToBMI(AllScores[3]) + ConvertToBMI(AllScores[4])) / 5; 
        float MeanBMI2 = (ConvertToBMI(AllScores[5]) + ConvertToBMI(AllScores[6]) + ConvertToBMI(AllScores[7]) + ConvertToBMI(AllScores[8]) + ConvertToBMI(AllScores[9])) / 5;
        float MeanDoor = (AllScores[10] + AllScores[11] + AllScores[12] + AllScores[13]) / 4;

        TextMean.GetComponent<Text>().text = "BMI = " + MeanBMI1.ToString("F2") + "\n\nBMI = " + MeanBMI2.ToString("F2") + "\n\nDoor = " + MeanDoor.ToString("F2");

    }

    float ConvertToBMI(float id)
    {
        // BMI = 2 * AvatarID + 13;
        return 2 * id + 13;
    }

    float[] ConvertStringToFloatArray(string input)
    {
        string[] stringNumbers = input.Split(' ');
        float[] floatArray = new float[14];
        for (int i = 0; i < 14; i++)
        {
            if (i < stringNumbers.Length)
            {
                if (float.TryParse(stringNumbers[i], out float result))
                {
                    floatArray[i] = result;
                }
                else
                {
                    Debug.LogWarning($"Unable to parse '{stringNumbers[i]}' into a float.");
                    floatArray[i] = 0f;
                }
            }
            else
            {
                Debug.LogWarning("Input string does not contain enough numbers.");
                floatArray[i] = 0f;
            }
        }

        return floatArray;
    }

}
