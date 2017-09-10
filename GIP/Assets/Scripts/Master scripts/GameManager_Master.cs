using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventFinishLevel;

    public void CallEventFinishLevel()
    {

    }
}
