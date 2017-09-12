using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_Master : MonoBehaviour {

    public delegate void LevelEventHandler(int currentLevel, int wantedLevel);

    public event LevelEventHandler EventGoToLevel;
    public event LevelEventHandler EventGoToNextLevel;
    public event LevelEventHandler EventRestartLevel;

    public void CallEventGoToLevel(int currentLevel, int wantedLevel)
    {
        Debug.Log("Loading level: " + wantedLevel);
        EventGoToLevel(currentLevel, wantedLevel);
    }

    public void CallEventGoToNextLevel(int currentLevel)
    {
        Debug.Log("Going to the next level...");

        if(currentLevel == 0)
        {
            currentLevel = SceneManager.GetActiveScene().buildIndex;
        }

        if(EventGoToNextLevel != null)
            EventGoToNextLevel(currentLevel, currentLevel + 1);

        EventGoToLevel(currentLevel, currentLevel + 1);
    }

    public void CallEventRestartLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Restarting level " + currentLevel);
        CallEventGoToLevel(currentLevel, currentLevel);
    }


}
