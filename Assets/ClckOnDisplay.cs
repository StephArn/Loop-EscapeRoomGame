using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClckOnDisplay : MonoBehaviour
{
    public void OnMouseDown()
    {
        Debug.Log("DA");
        // Camera.main.enabled = false;
        this.GetComponentsInChildren<Camera>()[0].enabled = true;
    }
}
