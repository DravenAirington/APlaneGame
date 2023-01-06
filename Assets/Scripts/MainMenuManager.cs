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
        SceneManager.LoadScene(1);
    }

  public void openStore()

    {
        SceneManager.LoadScene(2);
    }
}
