using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Master : MonoBehaviour {

    public delegate void SaveEventHandler(int currentLevel);

    public event SaveEventHandler EventSaveLevel;

    public void CallEventSaveLevel(int currentLevel)
    {
        EventSaveLevel(currentLevel);
    }
}
