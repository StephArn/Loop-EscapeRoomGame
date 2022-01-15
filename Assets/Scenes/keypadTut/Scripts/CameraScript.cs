using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static float speed;
    public FixedJoystick variableJoystick;
    public Camera cam;

    private float xValue = 0f;
    private float yValue = 0f;

    private void Start()
    {
        speed = 3f;
        Application.targetFrameRate = 60;
        variableJoystick.AxisOptions = AxisOptions.Both;

    }

    public void FixedUpdate()
    {
        if (variableJoystick.Vertical != 0 || variableJoystick.Horizontal != 0)
        {
            xValue -= variableJoystick.Vertical * speed;
            yValue += variableJoystick.Horizontal * speed;
            cam.transform.rotation = Quaternion.Euler(xValue, yValue, 0f);
        }

    }
}
