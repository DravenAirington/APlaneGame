using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Android;

public class StoreCameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera[] planeCams = new CinemachineVirtualCamera[13];


    private void OnEnable()
    {
        CamSwitcher.register(planeCams[12]);
    }
    private void OnDisable()
    {
        CamSwitcher.unregister(planeCams[12]);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            //switch cam
            if(CamSwitcher.IsActivecamera())
        }
    }
}
