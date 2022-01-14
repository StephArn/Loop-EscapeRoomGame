using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color mouseOverColor;
    public Color mouseOverColorExit;

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColorExit);

    }
}
