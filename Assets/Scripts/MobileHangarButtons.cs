using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileHangarButtons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    // Start is called before the first frame update
    void Start()
    {
#if (UNITY_IOS || UNITY_ANDROID)

#else
        button1.SetActive(false);
        button2.SetActive(false);
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
