using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    public void StartNew()
    {
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(1);
    }

  public void openStore()

    {
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(2);
    }
}
