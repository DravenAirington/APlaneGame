using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("rusty coin"))
        {
            GameManager.instance.CollectCoin(1);
            GameManager.instance.scoreTime += 3;
        }
        if (other.CompareTag("silver coin"))
        {
            GameManager.instance.CollectCoin(5);
            GameManager.instance.scoreTime += 10;
        }
        if (other.CompareTag("Copper coin"))
        {
            GameManager.instance.CollectCoin(2);
            GameManager.instance.scoreTime += 5;
        }
        if (other.CompareTag("Gold Coin"))
        {
            GameManager.instance.CollectCoin(10);
            GameManager.instance.scoreTime += 15;
        }
    }

}
