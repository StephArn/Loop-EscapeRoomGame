using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject optionsPage;
    public GameObject creditsPage;
    public GameObject frame0;
    public GameObject frame1;
    public GameObject frame2;

    // Start is called before the first frame update
    void Start()
    {
        frame0.SetActive(true);
        frame1.SetActive(false);
        frame2.SetActive(false);
        optionsPage.SetActive(false);
        creditsPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
