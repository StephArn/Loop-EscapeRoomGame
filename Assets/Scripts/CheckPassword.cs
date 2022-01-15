using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{
    public InputField input;

   public void Check() 
   {
        print(input.text);

      

        if (input.text == "dejavu")
        {
            // Camera.main.enabled = false;
            this.GetComponentsInChildren<Camera>()[0].enabled = false;
        }

    }

}
