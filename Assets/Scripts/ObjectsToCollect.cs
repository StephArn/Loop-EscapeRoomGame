using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour 
{
    public static int objects = 3;
	// Use this for initialization
	void Awake () 
	{
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            objects--;
		
		//AudioSource audio = gameObject.addComponent<AudioSource >();
		//audio.PlayOneShot((AudioClip)Assets.Load("shock.mp3"));

        gameObject.SetActive(false);
    }
}