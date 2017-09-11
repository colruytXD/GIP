using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ToggleLevelFailPanel : MonoBehaviour {

    GameManager_Master gm;

    [SerializeField]
    GameObject pnlLevelFail;

    private void OnEnable()
    {
        gm = GetComponent<GameManager_Master>();
        gm.EventLevelFailed += TogglePanel;
    }

    private void OnDisable()
    {
        gm.EventLevelFailed -= TogglePanel;
    }

    void TogglePanel()
    {
        pnlLevelFail.SetActive(!pnlLevelFail.activeSelf);
    }
}
