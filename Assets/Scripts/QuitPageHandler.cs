using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitPageHandler : MonoBehaviour
{
    public Button yesBtn;
    public Button noBtn;
    public GameObject frame1;
    public GameObject frame2;

    // Start is called before the first frame update
    void Start()
    {
        noBtn.onClick.AddListener(loadMainMenu);
    }

    void loadMainMenu()
    {
        frame1.SetActive(true);
        frame2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
