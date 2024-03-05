using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] GameObject inGameMenuCanvas;
    bool showMenu = true;


    void Start()
    {
        CloseMenu();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            showMenu = !showMenu;

            if (showMenu)
            {
                DisplayMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }


    public void CloseMenu()
    {
        showMenu = false;
        inGameMenuCanvas.SetActive(false);
    }


    public void DisplayMenu()
    {
        showMenu = true;
        inGameMenuCanvas.SetActive(true);
    }


    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }


    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
