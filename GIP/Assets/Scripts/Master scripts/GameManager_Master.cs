using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

    private Levels_Master levelMaster;

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventLevelFailed;

    public void CallEventLevelFailed()
    {
        if(EventLevelFailed != null)
            EventLevelFailed();

        levelMaster.CallEventRestartLevel();
    }

    private void Start()
    {
        levelMaster = GetComponent<Levels_Master>();
    }
}
