using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject optionsPage;
    public Button optionsBtn;

    // Start is called before the first frame update
    void Start()
    {
        optionsBtn.onClick.AddListener(loadOptionsPage);
    }

    void loadOptionsPage()
    {
        optionsPage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
