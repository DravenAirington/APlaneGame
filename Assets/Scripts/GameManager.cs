using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int coinsCollected;
    public float scoreTime;
    public int score;
    public bool isGameOver, saveScore;
    public static GameManager instance;
    public TextMeshProUGUI scoreLabel, coinLabel;
    public TextMeshProUGUI goScoreLabel, goCoinLabel, goHiscore;
    public Material[] skyBox;


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
        saveScore = false;
        int randSkybox = Random.Range(0, skyBox.Length - 1);
        RenderSettings.skybox = skyBox[randSkybox];

    }

    public void GameOver()
    {
        isGameOver = true;
        PlayerData.instance.SaveHighScore(score);
        goCoinLabel.text = "Coins: " + coinsCollected;
        goScoreLabel.text = "Score: " + score;
        goHiscore.text = "Highscore: " + PlayerData.instance.highScore;

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true && saveScore == false)
        {
            PlayerData.instance.SaveCoins(coinsCollected);
            PlayerData.instance.SaveHighScore(score);
            saveScore = true;
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
