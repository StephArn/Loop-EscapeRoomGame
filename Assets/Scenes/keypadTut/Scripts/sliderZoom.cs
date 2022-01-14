using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderZoom : MonoBehaviour
{
    Camera maincamera;
    public float zoomAMT = 60f;

    void Start()
    {
        maincamera = GetComponent<Camera>();
    }
    void Update()
    {
        maincamera.fieldOfView = zoomAMT;

        if ( zoomAMT == 60)
        {
            CameraScript.speed = 3;
        }
        if (zoomAMT <= 60 && zoomAMT >= 50)
        {
            CameraScript.speed = 2;
        }
        if (zoomAMT <= 50 && zoomAMT >= 40)
        {
            CameraScript.speed = 1;
        }
        if (zoomAMT <= 40 && zoomAMT >= 30)
        {
            CameraScript.speed = 0.8f;
        }
        if (zoomAMT <= 30)
        {
            CameraScript.speed = 0.4f;
        }
    }

    public void sliderZoomInOut(float zoom)
    {
        zoomAMT = zoom;
    }
}
