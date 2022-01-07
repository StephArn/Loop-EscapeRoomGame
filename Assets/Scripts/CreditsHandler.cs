using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsHandler : MonoBehaviour
{
    public Button backBtn;
    public GameObject creditsPage;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(closeCreditsPage);
    }

    void closeCreditsPage()
    {
        mainMenu.SetActive(true);
        creditsPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
