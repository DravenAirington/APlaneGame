using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int coins;
    public int highScore;
    public static PlayerData instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
           
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        highScore = PlayerPrefs.GetInt("Score", 0);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveCoins(int coinsToSave)
    {
        coins += coinsToSave;
        PlayerPrefs.SetInt("Coins", 0);
    }
    public void SaveHighScore(int highScoreToSave)
    {
        if(highScoreToSave > highScore)
        {
            highScore = highScoreToSave;
            PlayerPrefs.SetInt("Score", 0);
        }
            

    }
}
