using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    public Color startColor;
    public Text text;
    public float colorValue;
    public bool brighten;

    // Start is called before the first frame update
    void Start()
    {
        colorValue = 255;
        brighten = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(colorValue <= 255 && colorValue >= 100)
        {
            if (brighten == true)
                colorValue += 1f;
            else
                colorValue -= 1f;
        }
        if (colorValue <= 100)
        {
            colorValue = 100;
            brighten = true;
        }
        if (colorValue >= 255)
        {
            colorValue = 255;
            brighten = false;
        }

        startColor = new Color(colorValue, colorValue, colorValue, colorValue);
        text.color = startColor;
    }
}
