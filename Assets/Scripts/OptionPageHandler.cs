using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPageHandler : MonoBehaviour
{
    public Button backBtn;
    public GameObject optionsPage;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(closeOptionsPage);
    }

    void closeOptionsPage()
    {
        mainMenu.SetActive(true);
        optionsPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
