using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int coinsCollected;
    public float scoreTime;
    public int score;
    public bool isGameOver;
    public static GameManager instance;
    public TextMeshProUGUI scoreLabel, coinLabel;


    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
        score = 0;
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            PlayerData.instance.SaveCoins(coinsCollected);
            PlayerData.instance.SaveHighScore(score);
        }

        if(isGameOver == false)
        {
            scoreTime += Time.deltaTime;
            score = (int)scoreTime;

        }

        scoreLabel.text = "Score: " + score;
        coinLabel.text = "Coins: " + coinsCollected;

    }
    public void CollectCoin(int coinAmount)
    {
        coinsCollected += coinAmount;
    }

}
