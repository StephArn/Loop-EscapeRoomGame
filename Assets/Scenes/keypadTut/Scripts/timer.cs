using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public Text textArea;
    public float timerTotal = 305f;

    private bool stopTimer;
    private bool playDieAudio;

    public AudioSource dieSound;

    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        playDieAudio = false;
    }

    // Update is called once per frame
    void Update()
    {
        float time = timerTotal - Time.timeSinceLevelLoad;

        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time - minutes * 60);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if ( time <=0 )
        {
            stopTimer = true;
            if (playDieAudio == false)
            {
                playDieAudio = true;   
                StartCoroutine(LoadMainScreen("MainScreen"));
            }
            //SceneManager.LoadScene(0);

        }

        if ( stopTimer == false)
        {
             textArea.text = textTime;

        }

    }
    IEnumerator LoadMainScreen(string level01)
    {
        dieSound.Play();
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(0);
    }

}
