using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int loadGameIdx = 2;

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }


    public void LoadGame()
    {
        SceneManager.LoadScene(loadGameIdx);
    }

   
    public void ExitGame()
    {
        Application.Quit();
    }
}
