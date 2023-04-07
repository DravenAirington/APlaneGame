using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader 
{
    // Start is called before the first frame update


    // Update is called once per frame
    public static int levelToLoad = 0;
    

    public static void LoadTheScene(int sceneToLoad)
    {
#if UNITY_WSA
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
#endif
        levelToLoad = sceneToLoad;
        SceneManager.LoadScene(3);
    }
}
