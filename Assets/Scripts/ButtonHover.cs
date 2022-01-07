using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{

    public Text theText;
    public Button button;
    public int initialFontSize;

    public void ChangeSizeEnter()
    {
        theText.fontSize = initialFontSize + 3;
    }

    public void ChangeSizeExit()
    {
        theText.fontSize = initialFontSize;

    }

    void Start()
    {
        initialFontSize = theText.fontSize;
    }

    /*
        public void ChangeColorEnter()
        {
            theText.color = Color.white;
        }

        public void ChangeColorExit()
        {
            theText.color = Color.black;
        }   
    */


}