using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public int coinsCollected;
    public float scoreTime;
    public float selfDestructTime;
    public int score;
    public bool isGameOver, saveScore;
    public static GameManager instance;
    public TextMeshProUGUI scoreLabel, coinLabel, selfDestructTimeLabel;
    public TextMeshProUGUI goScoreLabel, goCoinLabel, goHiscore;
    public Material[] skyBox;
    public GameObject restrtButton;
    public Transform player;
    public GameObject uiCam;
    public GameObject GOpanel;
    public GameObject mobileController;


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
        selfDestructTime = 30;
    }

    public void GameOver()
    {
        isGameOver = true;
        PlayerData.instance.SaveHighScore(score);
        goCoinLabel.text = "Coins: " + coinsCollected;
        goScoreLabel.text = "Score: " + score;
        goHiscore.text = "Highscore: " + PlayerData.instance.highScore;
        EventSystem.current.SetSelectedGameObject(restrtButton);
#if (UNITY_IOS || UNITY_ANDROID)
        mobileController.SetActive(false);
#endif
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
            scoreTime = player.position.z;
            score = (int)scoreTime;
            selfDestructTime -= Time.deltaTime;

        }

        if(selfDestructTime <= 0)
        {
            GOpanel.SetActive(true);
            uiCam.SetActive(true);
            Destroy(player.gameObject);
            GameOver();
        }

        selfDestructTimeLabel.text = "Self Destruct Time: " + selfDestructTime;
        scoreLabel.text = "Score: " + score;
        coinLabel.text = "Coins: " + coinsCollected;

    }
    public void CollectCoin(int coinAmount)
    {
        coinsCollected += coinAmount;
    }

}
