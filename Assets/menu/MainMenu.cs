using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");

    }
    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu");

    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
