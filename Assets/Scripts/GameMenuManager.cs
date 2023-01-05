using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;

    public void openPanel()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
        Button.SetActive(false);
    }

    public void closePanel()
    { 
        Panel.SetActive(false);
        Time.timeScale = 1.0f;
        Button.SetActive(true);
    }

    public void homeButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void reloadGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    
}
