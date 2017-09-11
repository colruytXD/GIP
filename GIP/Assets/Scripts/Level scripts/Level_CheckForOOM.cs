using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_CheckForOOM : MonoBehaviour {

    [SerializeField]
    GameManager_Master gm;

    private void OnTriggerEnter(Collider other)
    {
        print(other + " is OOM");
        if(other.tag == "Player")
        {
            gm.CallEventLevelFailed();
        }
    }
}
