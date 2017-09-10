using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels_Master : MonoBehaviour {

    public delegate void LevelEventHandler(int currentLevel, int wantedLevel);

    public event LevelEventHandler EventGoToLevel;
    public event LevelEventHandler EventGoToNextLevel;
    public event LevelEventHandler EventRestartLevel;

    public void CallEventGoToLevel(int currentLevel, int wantedLevel)
    {
        EventGoToLevel(currentLevel, wantedLevel);
    }

    public void CallEventGoToNextLevel(int currentLevel, int wantedLevel)
    {
        EventGoToNextLevel(currentLevel, wantedLevel);
    }

    public void CallEventRestartLevel(int currentLevel, int wantedLevel)
    {
        EventRestartLevel(currentLevel, wantedLevel);
    }


}
