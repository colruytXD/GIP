using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_ToggleControl : MonoBehaviour {

    [SerializeField]
    GameManager_Master gm;

    private void OnEnable()
    {
        gm.EventLevelCompleted += ToggleControl;
        gm.EventLevelFailed += ToggleControl;
    }

    private void OnDisable()
    {
        gm.EventLevelCompleted -= ToggleControl;
        gm.EventLevelFailed -= ToggleControl;
    }
    void ToggleControl()
    {
        GetComponent<FirstPersonController>().enabled = !GetComponent<FirstPersonController>().enabled;

        Cursor.visible = !Cursor.visible;

        if (Cursor.lockState == CursorLockMode.Locked)
            Cursor.lockState = CursorLockMode.None;
        else
            Cursor.lockState = CursorLockMode.Locked;

    }
}
