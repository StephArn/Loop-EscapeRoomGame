using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class buttonPress : MonoBehaviour
{
    public static event Action<string> ButtonPressed = delegate { };

    private string buttonName, buttonValue;

    // Start is called before the first frame update
    void Start()
    {
        buttonName = gameObject.name;
        buttonValue = buttonName.Substring(7);
        gameObject.GetComponent<Button>().onClick.AddListener(changeText);
    }
    
    void changeText()
    {
        ButtonPressed(buttonValue);
    }
    
}
