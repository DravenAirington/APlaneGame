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
            GameManager.instance.scoreTime += 3;
            other.gameObject.SetActive(false);
            GameManager.instance.selfDestructTime += 2.5f;
        }
        if (other.CompareTag("silver coin"))
        {
            GameManager.instance.CollectCoin(5);
            GameManager.instance.scoreTime += 10;
            other.gameObject.SetActive(false);
            GameManager.instance.selfDestructTime += 2.5f;
        }
        if (other.CompareTag("Copper coin"))
        {
            GameManager.instance.CollectCoin(2);
            GameManager.instance.scoreTime += 5;
            other.gameObject.SetActive(false);
            GameManager.instance.selfDestructTime += 2.5f;
        }
        if (other.CompareTag("Gold Coin"))
        {
            GameManager.instance.CollectCoin(10);
            GameManager.instance.scoreTime += 15;
            other.gameObject.SetActive(false);
            GameManager.instance.selfDestructTime += 2.5f;
        }
    }
}
