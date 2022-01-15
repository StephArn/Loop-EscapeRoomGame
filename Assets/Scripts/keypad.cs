using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keypad : MonoBehaviour
{

    // Object to be enabled is the keypad. This is needed
    public GameObject keycode1;
    
    // *** Breakdown of header(public) variables *** \\
    // curPassword : Pasword to set. Ive set the password in the project. Note it can be any length and letters or numbers or sysmbols
    // input: What is currently entered
    // displayText : Text area on keypad the password entered gets displayed too.
    // audioData : Play this sound when user enters in password incorrectly too many times
    
    
    [Header("Keypad Settings")]
    public Animator animator;
    public string curPassword = "1234";
    public string input;
    public Text displayText;
    public AudioSource audioData;

    //Local private variables
    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;

    // Start is called before the first frame update
    void Start()
    {
        btnClicked = 0; // No of times the button was clicked
        numOfGuesses = curPassword.Length; // Set the password length.
        // animator = GetComponent<Animator>();
        buttonPress.ButtonPressed += ValueEntered;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (btnClicked == numOfGuesses)
        {
            if (input == curPassword)
            {
                //Load the next scene
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
                // LOG message that password is correct
                Debug.Log("Correct Password!");
                input = ""; //Clear Password
                btnClicked = 0;
                
                // we show the buttons
                // animator.SetTrigger("CorrectPassword");
            }
            else
            {
                btnClicked = 0;
                //Reset input varible
                Debug.Log("Incorrect Password!");
                input = "";
                //displayText.text = input.ToString();
                //audioData.Play();
            }
        }
    }
    
    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                keycode1.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                // if (btnClicked == numOfGuesses)
                // {
                //     btnClicked = 0;
                //     input = "";
                // }
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }
    }

    void OnGUI()
    {
        // Action for clicking keypad( GameObject ) on screen
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("keypad")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    keypadScreen = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        keypadScreen = true;
                    }
                }

                if (selection.CompareTag("numberBtn")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    Debug.Log("number pressed");
                    // ValueEntered("1");
                }
            }
        }

        // Disable sections when keypadScreen is set to true
        if (keypadScreen)
        {
            keycode1.SetActive(true);
        }

    }
}
