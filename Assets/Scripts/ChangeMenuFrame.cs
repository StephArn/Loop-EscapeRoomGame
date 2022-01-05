using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenuFrame : MonoBehaviour
{
    public GameObject camera0;
    public GameObject camera1;
    public GameObject frame0;
    public GameObject frame1;
    // Start is called before the first frame update

    void Start()
    {
        frame0.SetActive(true);
        frame1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            camera1.SetActive(true);
            camera0.SetActive(false);
            frame1.SetActive(true);
            frame0.SetActive(false);
        }
    }
}
