using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadExit : MonoBehaviour
{
    public Button saveBtn;
    public Button loadBtn;
    public Button exitBtn;

    public GameObject player;
    public GameObject backToMainMenu;
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        saveBtn.onClick.AddListener(saveGame);
        loadBtn.onClick.AddListener(loadGame);
        exitBtn.onClick.AddListener(exitGame);
    }

    void saveGame()
    {
        Debug.Log("Game Saved");
    }

    void loadGame()
    {
        Debug.Log("Game Loaded");
    }

    void exitGame()
    {
        mainMenu.SetActive(true);
        player.SetActive(false);
        backToMainMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
