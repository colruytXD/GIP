using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_CheckForEndOfLevel : MonoBehaviour {

    [SerializeField]
    private GameManager_Master gm;

    private void OnTriggerEnter(Collider other)
    {
        gm.CallEventLevelCompleted();
    }
}
