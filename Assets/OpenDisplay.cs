using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDisplay : MonoBehaviour
{
    //Local private variables
    private bool keypadScreen = false;
    public GameObject keycode1;
    public GameObject canvas;
    public GameObject passwordCamera;
    public InputField input;
    public GameObject changeTextColor;

    void OnGUI()
    {
        // Action for clicking keypad( GameObject ) on screen
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("keypad")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    keypadScreen = true;

                }

            }
        }

        // Disable sections when keypadScreen is set to true
        if (keypadScreen)
        {
            //keycode1.SetActive(true);
            canvas.SetActive(true);
            passwordCamera.SetActive(true);
            // Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, passwordCamera.transform.position, Time.deltaTime * 1);
            Check();
           
        }
    }

    public void Check()
    {
        print(input.text);

        if (input.text == "dejavu")
        {
            changeTextColor.GetComponent<Text>().color = new Color(0f, 1f, 0f, 1f);
            print("Passed!");
            SceneManager.LoadScene(0);
        }
        else
        {
            changeTextColor.GetComponent<Text>().color = new Color(1f, 0f, 0f, 1f);
        }

    }
}
