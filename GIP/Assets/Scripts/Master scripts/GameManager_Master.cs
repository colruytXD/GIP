using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventLevelFailed;
    public event GeneralEventHandler EventLevelCompleted;

    public void CallEventLevelFailed()
    {
        EventLevelFailed();
    }

    public void CallEventLevelCompleted()
    {
        EventLevelCompleted();
    }

    private void Start()
    {
    }
}
