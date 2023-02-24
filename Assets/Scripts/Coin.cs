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
