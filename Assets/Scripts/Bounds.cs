using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        //Destroy(other.gameObject);
        player.transform.position = respawnPoint.transform.position;
        player.transform.rotation = respawnPoint.transform.rotation;

    }
}
