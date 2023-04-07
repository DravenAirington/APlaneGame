using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void BackToMenu()
    {
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(0);
    }
}
