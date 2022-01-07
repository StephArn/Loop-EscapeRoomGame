using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject optionsPage;
    public GameObject creditsPage;
    public GameObject frame1;
    public GameObject frame2;
    public Button optionsBtn;
    public Button creditsBtn;
    public Button quitBtn;


    // Start is called before the first frame update
    void Start()
    {
        optionsBtn.onClick.AddListener(loadOptionsPage);
        creditsBtn.onClick.AddListener(loadCreditsPage);
        quitBtn.onClick.AddListener(loadQuitPage);

    }

    void loadOptionsPage()
    {
        optionsPage.SetActive(true);
    }

    void loadCreditsPage()
    {
        creditsPage.SetActive(true);
        frame1.SetActive(false);
    }

    void loadQuitPage()
    {
        frame2.SetActive(true);
        frame1.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
