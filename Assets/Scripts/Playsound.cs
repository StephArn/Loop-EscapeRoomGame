using UnityEngine;
using System.Collections;

public class Playsound : MonoBehaviour 

{
	public void Clicky (){
		GetComponent<AudioSource>().Play();
	}


}
