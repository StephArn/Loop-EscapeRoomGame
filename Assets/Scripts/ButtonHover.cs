using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{

    public Text theText;
    public Button button;

    public void ChangeColorEnter()
    {
        theText.color = Color.white;
    }

    public void ChangeColorExit()
    {
        theText.color = Color.black;
    }

/*    public void ChangeSizeEnter()
    {
        button.image.rectTransform.sizeDelta = new Vector2(260f, 45f);
    }

    public void ChangeSizeExit()
    {
        button.image.rectTransform.sizeDelta = new Vector2(250f, 40f);

    }
*/
}
