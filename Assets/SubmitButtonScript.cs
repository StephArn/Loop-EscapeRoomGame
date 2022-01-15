using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButtonScript : MonoBehaviour
{
    public Text inputPassword;
    //public Object passwordCamera;
    // Start is called before the first frame update
    public void Submit()
    {
      //  gameObject.GetComponent<Text>() = "buna";
        print(inputPassword.text);
    }

}
