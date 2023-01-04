using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingsbutton : MonoBehaviour
{
    public GameObject Panel;

    public void openPanel()
    {
        Panel.SetActive(true);
    }

    public void closePanel()
    {
        Panel.SetActive(false);
    }
}
