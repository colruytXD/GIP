using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ToggleNextLevelPanel : MonoBehaviour {

    [SerializeField]
    private GameObject pnlNextLevel;

    private GameManager_Master gm;

    private void OnEnable()
    {
        gm = GetComponent<GameManager_Master>();
        gm.EventLevelCompleted += TogglePanel;
    }

    private void OnDisable()
    {
        gm.EventLevelCompleted -= TogglePanel;
    }

    void TogglePanel()
    {
        pnlNextLevel.SetActive(!pnlNextLevel.activeSelf);
    }
}
