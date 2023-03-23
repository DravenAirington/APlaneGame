using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int[] planes = {
    
     1,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0,
     0
    };

    public int coins;
    public int highScore;
    public int currentPlane;

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
        currentPlane = PlayerPrefs.GetInt("CurrentPlane" , 0);
        GetPlanes();
        

    }
    public void SavePlane(int planeNumber)
    {
        PlayerPrefs.SetInt("Plane"+planeNumber, 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetPlanes()
    {
        for(int i = 0; i < planes.Length; i++)
        {

            if(i == 0)
                planes[i] = PlayerPrefs.GetInt("Plane"+i, 1);
            else
                planes[i] = PlayerPrefs.GetInt("Plane"+i, 0);

        }
    }

    public void SaveCoins(int coinsToSave)
    {
        coins += coinsToSave;
        PlayerPrefs.SetInt("Coins", coins);
    }
    public void SaveHighScore(int highScoreToSave)
    {
        if(highScoreToSave > highScore)
        {
            highScore = highScoreToSave;
            PlayerPrefs.SetInt("Score", highScore);
        }
            

    }
}
