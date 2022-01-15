using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{

    public Camera cam;
    public VariableJoystick variableJoystick;

    public float rotSpeed = 0.5f;

    private float rotX = 0f;
    private float rotY = 0f;
    private Vector3 origRot;

    // Start is called before the first frame update
    void Start()
    {
        origRot = cam.transform.eulerAngles;
        rotX = origRot.x;
        rotY = origRot.y;

    }

    // Update is called once per frame
    void Update()
    {
        //rotx = Joystick.  
        if (variableJoystick.Vertical != 0 && variableJoystick.Horizontal != 0)
        {
            Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;

            rotX = variableJoystick.Vertical * rotSpeed + origRot.x;
            rotY = variableJoystick.Horizontal * rotSpeed + origRot.y;
            Debug.Log(direction.x);
            Debug.Log(direction.y);
            rotX = Mathf.Clamp(direction.x, -45f, 45f);

            cam.transform.eulerAngles = new Vector3(direction.x * rotSpeed, direction.y * rotSpeed, 0f);

        }
        else
        {
            cam.transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }

    }
}
