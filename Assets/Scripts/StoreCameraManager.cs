using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Cinemachine;
using UnityEngine.Android;

public class StoreCameraManager : MonoBehaviour
{
    public GameObject[] cams = new GameObject[13];
    public GameObject[] allButtons;
    int activeCamera = 0;
    public BackButton backbutton;

    public void OnLeft(InputValue value)
    {
        PrevCam();
        EventSystem.current.SetSelectedGameObject(allButtons[activeCamera]);
    }
    public void OnRight(InputValue Value)
    {
        NextCam();
        EventSystem.current.SetSelectedGameObject(allButtons[activeCamera]);
    }
    public void OnBack(InputValue Value)
    {
        backbutton.BackToMenu();
    }

    public void NextCam()
    {
        int previousCam = activeCamera;
        if (activeCamera == cams.Length - 1)
        {
            activeCamera = 0;
        }
        else
        {
            activeCamera++;
        }
       
        cams[previousCam].SetActive(false);
        cams[activeCamera].SetActive(true);
    }

    public void PrevCam()
    {
        int previousCam = activeCamera;
        if(activeCamera == 0)
        {
           
        }
        else
        {
         activeCamera--;
         cams[previousCam].SetActive(false);
         cams[activeCamera].SetActive(true);
        }
        
    }
}
