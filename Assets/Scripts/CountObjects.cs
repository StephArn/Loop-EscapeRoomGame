using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
    public GameObject light;
	public GameObject portal;
	//public GameObject ObjectNum;
    GameObject objUI;
    
	// Use this for initialization
	void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }

	// Update is called once per frame
	void Update () 
	{
		//if (ObjectNum.active == true)
		//{
        	objUI.GetComponent<Text>().text = ObjectsToCollect.objects.ToString();
        	if (ObjectsToCollect.objects == 0)
        	{
				objUI.GetComponent<Text>().text = "All done!";

				// sunet portal
				light.SetActive(true);
				portal.SetActive(true);
        	}
		//}
	}
}