using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowCoins : MonoBehaviour
{
    public TextMeshProUGUI coinLabel;
    // Start is called before the first frame update
    void Start()
    {
        coinLabel.text = "Coins: " + PlayerData.instance.coins;
    }

    // Update is called once per frame
    void Update()
    {
        if (coinLabel.text != "Coins: " + PlayerData.instance.coins)
        {
            coinLabel.text = "Coins: " + PlayerData.instance.coins;
        }
    }
}
