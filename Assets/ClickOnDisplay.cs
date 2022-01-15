using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnDisplay : MonoBehaviour
{
    void onClick()
    {
        Camera.main.enabled = false;
        this.GetComponentsInChildren<Camera>()[0].enabled = true;
    }
}
