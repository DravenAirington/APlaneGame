using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.Android;

public class StoreCameraManager : MonoBehaviour
{
    public GameObject[] cams = new GameObject[13];
    int activeCamera = 0;


    public void OnLeft(InputValue value)
    {
        PrevCam();
    }
    public void OnRight(InputValue Value)
    {
        NextCam();
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
