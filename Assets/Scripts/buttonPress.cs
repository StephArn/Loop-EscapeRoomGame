using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonPress : MonoBehaviour
{
    public Button button;
    public Text displayText;
    
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(changeText);
    }
    
    void changeText()
    {
        string nr = button.GetComponentInChildren<Text>().text;
        displayText.text += nr;
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
