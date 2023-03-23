using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BuyPlane : MonoBehaviour
{
    private TextMeshProUGUI buttonText;
    public int planeNumber;
    int[] planesPrice =
     {
        0,
        200,
        400,
        600,
        800,
        1000,
        1200,
        1400,
        1600,
        1800,
        2000,
        2500,
        3000,
        3250,
        3500,
        3750,
        4000,
        4250,
        4500,
        5500,
        6500,
        7500
    };

    public void Select()
    {
        PlayerData.instance.currentPlane = planeNumber;
       PlayerPrefs.SetInt("CurrentPlane", planeNumber
           );
    }
    public void BuySelect()
    {
        Debug.Log("called");
        if (PlayerData.instance.planes[planeNumber] == 0)
        {
            Buy(planeNumber);
        }
        else if (PlayerData.instance.planes[planeNumber] == 1 && PlayerData.instance.currentPlane != planeNumber)
        {
            Select();
        }
        SetButtonText();
    }
    public void Buy(int plane)
    {
        if(PlayerData.instance.coins >= planesPrice[plane])
        {
            PlayerData.instance.planes[plane] = 1;
            PlayerData.instance.SaveCoins(-planesPrice[plane]);
            PlayerData.instance.SavePlane(plane);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        SetButtonText();
        GetComponent<Button>().onClick.AddListener(BuySelect);
    }
    private void SetButtonText()
    {
        if (PlayerData.instance.planes[planeNumber] == 0 )
        {
            buttonText.text = "Buy";
        }
        else if (PlayerData.instance.planes[planeNumber] == 1 && PlayerData.instance.currentPlane != planeNumber)
        {
            buttonText.text = "Use";
        }
        else
        {
            buttonText.text = "Using";
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetButtonText();
    }
}
