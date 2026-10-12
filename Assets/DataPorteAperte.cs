using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class DataPorteAperte : MonoBehaviour
{
    public float Distance = 3.0f;
    public float maxDistance = 3.0f;
    public float minDistance = 0.0f;

    string thisPath = Application.streamingAssetsPath + "/";

    //devo creare una cartella e metterla sul desktop 
    public string fileNameFinale = "test";
    public string fileNameProgressivo = "progressivo";
    private string ext = ".txt";

    public float passo = 0.1f;

    public Transform AntaDx;
    public Transform AntaSx;
    //posizioni iniziali delle ante, ossia quando sono completamente aperte
    private Vector3 fullOpenPosDx;
    private Vector3 fullOpenPosSx;
    //posizioni aggiornate delle ante
    private Vector3 movimentoDx;
    private Vector3 movimentoSx;

    void Start()
    {
        //le ante sono inizialmente aperte completamente
        Distance = maxDistance;

        //ricavo le posizioni iniziali delle ante
        fullOpenPosDx = new Vector3(AntaDx.position.x, AntaDx.position.y, AntaDx.position.z - (maxDistance / 2));
        fullOpenPosSx = new Vector3(AntaSx.position.x, AntaSx.position.y, AntaSx.position.z + (maxDistance / 2));

        movimentoDx = fullOpenPosDx;
        movimentoSx = fullOpenPosSx;

        AntaDx.position = movimentoDx;
        AntaSx.position = movimentoSx;
    }

    void Update () {
        //if ((Input.GetButtonDown("XRI_Right_SecondaryButton") && Distance<3.0f) || (Input.GetButtonDown("XRI_Left_SecondaryButton") && Distance < 3.0f))
        if (Input.GetButtonDown("XRI_Right_SecondaryButton") || Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            if (Distance + passo < maxDistance)
            {
                movimentoSx.z += passo / 2;
                AntaSx.position = movimentoSx;

                movimentoDx.z -= passo / 2;
                AntaDx.position = movimentoDx;

                Distance += passo;
                Debug.Log(" Apertura");
                SaveTemporalDistance();
            }
            else
            {
                Distance = maxDistance;

                //porta le porte nella posizione corretta
                movimentoDx = fullOpenPosDx;
                movimentoSx = fullOpenPosSx;

                AntaDx.position = movimentoDx;
                AntaSx.position = movimentoSx;
            }
        }

    if (Input.GetButtonDown("XRI_Right_PrimaryButton") || Input.GetButtonDown("XRI_Left_PrimaryButton"))
       {
            if (Distance - passo > minDistance)
            {
                movimentoSx.z -= passo / 2;
                AntaSx.position = movimentoSx;

                movimentoDx.z += passo / 2;
                AntaDx.position = movimentoDx;

                Distance -= passo;
                Debug.Log("Chiusura");
                SaveTemporalDistance();
            }
            else
            {
                Distance = minDistance;

                //porta le porte nella posizione corretta
                movimentoDx = fullOpenPosDx + new Vector3(0f, 0f, (maxDistance - minDistance) / 2);
                movimentoSx = fullOpenPosSx - new Vector3(0f, 0f, (maxDistance - minDistance) / 2);

                AntaDx.position = movimentoDx;
                AntaSx.position = movimentoSx;
            }
        } 
   }

    public void SaveFinalDistance()
    {
        //string curPath = thisPath + fileNameFinale + ext;
        //File.AppendAllText(curPath, Distance + " \n");

        string filePath = PlayerPrefs.GetString("CurrentID");
        File.AppendAllText(filePath, Distance.ToString("F2") + " \n");
        PlayerPrefs.SetString("PlayerScores", PlayerPrefs.GetString("PlayerScores") + Distance.ToString("F2") + " ");

    }

    public void SaveTemporalDistance()
    {
        //string curPath = thisPath + fileNameProgressivo + ext;
        //File.AppendAllText(curPath, Distance + " \n");
    }
}