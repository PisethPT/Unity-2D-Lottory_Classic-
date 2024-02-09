using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingData : MonoBehaviour
{
    public int MyScoreData;
    public int IntData;
    public int level;
    public void SaveProgressScore()
    {
        MyScoreData = FindAnyObjectByType<GameManager>().PTSValues;
        IntData = FindAnyObjectByType<GameManager>().ptsNum;
        IntData = FindAnyObjectByType<GameManager>().level;
        PlayerPrefs.SetInt("Score", MyScoreData);
        PlayerPrefs.SetInt("Value", IntData);
        PlayerPrefs.SetInt("Level", IntData);
        Debug.Log("My Score: " +PlayerPrefs.GetInt("Score"));
        Debug.Log("My value: " + PlayerPrefs.GetInt("Value"));
        Debug.Log("Level: " + PlayerPrefs.GetInt("Level"));
    }

}

