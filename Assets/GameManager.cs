using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coinsCollected;
    public int score;
    public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
        score = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            
        }
    }
}
