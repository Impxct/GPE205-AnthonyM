using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //this will load build / level 1 (0)
        SceneManager.LoadScene("Level_0");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
