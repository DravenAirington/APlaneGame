using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public Slider loadingBar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadTheLevel(SceneLoader.levelToLoad));
    }
    IEnumerator LoadTheLevel(int index)
    {
#if UNITY_WSA
        LightmapSettings.lightmaps = new LightmapData[0];
        Resources.UnloadUnusedAssets();
#endif
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            loadingBar.value = progress;
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
