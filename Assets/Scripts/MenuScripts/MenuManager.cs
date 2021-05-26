using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Developers_Button()
    {
        SceneManager.LoadScene("DevelopersScene");
        moved.isPaused = false;
    }
    public void Game_Scene()
    {
        SceneManager.LoadScene("GameScene");
        moved.isPaused = false;
    }

    public void Start_Button()
    {
        SceneManager.LoadScene("LevelScene");
        moved.isPaused = false;
    }

    public void Help_Button()
    {
        SceneManager.LoadScene("HelpScene");
        moved.isPaused = false;
    }

    public void Menu_Button()
    {
        SceneManager.LoadScene("MenuScene");
        moved.isPaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }



    
}
