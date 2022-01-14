using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class gameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    [SerializeField]
    private GameObject loseText;

    public Text timerText;
    public float gameTimer = 20f;

    private bool win;
    private bool lose;

    public static bool youWin;
    void Start()
    {
        // Hide Text Fields When program starts
        winText.SetActive(false);
        loseText.SetActive(false);

        //Set field defaults on start
        win     = false;
        lose    = false;
    }

    // Update is called once per frame
    void Update()
    {       
        if (lose == false && win == false )
            {
            // Build Seconds
            float time = gameTimer - Time.time;

            int minutes = Mathf.FloorToInt(time / 60F);
            int seconds = Mathf.FloorToInt(time - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

            timerText.text = niceTime;
             
            if (seconds <= 0)
            {
                loseText.SetActive(true);
                lose = true;
            }


        }

        //Debug.Log( "X :" + pictures[8].rotation.eulerAngles.x + "Y :"+ pictures[8].rotation.eulerAngles.y + "Z "+ pictures[8].rotation.eulerAngles.z);

        if ( pictures[0].rotation.eulerAngles.x == 0  &&
             pictures[0].rotation.eulerAngles.y == 90   &&
             pictures[0].rotation.eulerAngles.z == 180  &&

             pictures[1].rotation.eulerAngles.x == 0 && 
             pictures[1].rotation.eulerAngles.y == 0 &&
             pictures[1].rotation.eulerAngles.z == 180 &&

             pictures[2].rotation.eulerAngles.x == 0 &&
             pictures[2].rotation.eulerAngles.y == 0 &&
             pictures[2].rotation.eulerAngles.z == 0 &&

             pictures[3].rotation.eulerAngles.x == 0 &&
             pictures[3].rotation.eulerAngles.y == 0 &&
             pictures[3].rotation.eulerAngles.z == 270 &&

             pictures[4].rotation.eulerAngles.x == 0 &&
             pictures[4].rotation.eulerAngles.y == 0 &&
             pictures[4].rotation.eulerAngles.z == 0 &&

             pictures[5].rotation.eulerAngles.x == 0 &&
             pictures[5].rotation.eulerAngles.y == 0 &&
             pictures[5].rotation.eulerAngles.z == 180 &&

             pictures[6].rotation.eulerAngles.x == 0 &&
             pictures[6].rotation.eulerAngles.y == 0 &&
             pictures[6].rotation.eulerAngles.z == 90 &&

             pictures[7].rotation.eulerAngles.x == 0 &&
             pictures[7].rotation.eulerAngles.y == 0 &&     
             pictures[7].rotation.eulerAngles.z == 270 &&


             pictures[8].rotation.eulerAngles.x == 0 &&
             pictures[8].rotation.eulerAngles.y == 0  &&    
             pictures[8].rotation.eulerAngles.z == 90 

            )
        {
            if (lose == false)
            {
                winText.SetActive(true);
                win = true;
            }
        }
    }
}
