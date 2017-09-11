using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_LoadLevel : MonoBehaviour { 
    private Levels_Master levelMaster;

    private void OnEnable()
    {
        levelMaster = GetComponent<Levels_Master>();
        levelMaster.EventGoToLevel += Load;
    }

    private void OnDisable()
    {
        levelMaster.EventGoToLevel -= Load;
    }

    void Load(int currentScene, int wantedScene)
    {
        Debug.Log("Loading level: " + wantedScene);
        SceneManager.LoadScene(wantedScene);
    }


}
