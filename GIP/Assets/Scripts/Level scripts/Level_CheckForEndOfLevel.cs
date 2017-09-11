using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_CheckForEndOfLevel : MonoBehaviour {

    [SerializeField]
    private Levels_Master levelMaster;

    private void OnTriggerEnter(Collider other)
    {
        levelMaster.CallEventGoToNextLevel(SceneManager.sceneCountInBuildSettings);
    }
}
