using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public GameObject GOpanel;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject.transform.root.gameObject);
        GOpanel.SetActive(true);
    }
}
