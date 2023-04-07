using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameMenuManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;
    public bool isPaused;
    public GameObject resumeButton;

    public void openPanel()
    {
        isPaused = true;
        Panel.SetActive(true);
        Time.timeScale = 0;
        Button.SetActive(false);
        EventSystem.current.SetSelectedGameObject(resumeButton);
    }

    public void closePanel()
    {
        isPaused = false;
        Panel.SetActive(false);
        Time.timeScale = 1.0f;
        Button.SetActive(true);
    }

    public void homeButton()
    {
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
        //SceneManager.LoadScene(0);
        SceneLoader.LoadTheScene(0);
        Time.timeScale = 1.0f;
    }

    public void reloadGame()
    {
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
        //SceneManager.LoadScene(1);
        SceneLoader.LoadTheScene(1);
        Time.timeScale = 1.0f;
    }

    
    
}
