using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPageHandler : MonoBehaviour
{
    public Button backBtn;
    public GameObject optionsPage;
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(closeOptionsPage);
    }

    void closeOptionsPage()
    {
        optionsPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
