using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public SpawnManager spawnManager;
    public GameObject uiCam;
    public GameObject GOpanel;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject.transform.root.gameObject);
        GOpanel.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
            other.gameObject.SetActive(false);
            spawnManager.SpawnNextObject();
    }
}
