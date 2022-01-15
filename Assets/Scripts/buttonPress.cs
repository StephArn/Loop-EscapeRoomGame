using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class buttonPress : MonoBehaviour
{
    public static event Action<string> ButtonPressed = delegate { };

    public void PlaybtnClicked()
    {
        Debug.Log("DA");
        Camera.main.enabled = false;
        this.GetComponentsInChildren<Camera>()[0].enabled = true;
    }

}
