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
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject.transform.root.gameObject);
            GOpanel.SetActive(true);
            uiCam.SetActive(true);
            GameManager.instance.GameOver();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            other.gameObject.SetActive(false);
            spawnManager.SpawnNextObject();
            
        }
          
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("rusty coin"))
        {
            GameManager.instance.CollectCoin(1);
        }
        if (other.CompareTag("silver coin"))
        {
            GameManager.instance.CollectCoin(5);
        }
        if (other.CompareTag("Copper coin"))
        {
            GameManager.instance.CollectCoin(2);
        }
        if (other.CompareTag("Gold Coin"))
        {
            GameManager.instance.CollectCoin(10);
        }
    }
}
