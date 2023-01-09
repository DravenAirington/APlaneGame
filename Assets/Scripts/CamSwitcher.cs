using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CamSwitcher
{
 static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera activeCamera = null;
    public static bool IsActivecamera(CinemachineVirtualCamera camera)
    {
        return camera == activeCamera;
    }
    public static void switchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 12;
        activeCamera = camera;
        foreach(CinemachineVirtualCamera c in cameras)
        {
            if(c != camera)
            {
                c.Priority = 0;
            }
        }
    }
    public static void register(CinemachineVirtualCamera camera)
    {
        cameras.Add(camera);
        Debug.Log("Camera Registered: " + camera);
    }
    public static void unregister(CinemachineVirtualCamera camera)
    {
        cameras.Remove(camera);
        Debug.Log("Camera Unregistered " + camera);
    }
}
