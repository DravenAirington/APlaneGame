using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> objectList = new List<GameObject>();
    private List<GameObject> pooledObjects = new List<GameObject>();
    private float distance = 200f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmp;
        for (int i = 0; i < 14; i++)
        {
            tmp = Instantiate(objectList[i]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        RandomObject(8);

    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector3 Position()
    {
        Vector3 Pos = new Vector3(0, 0, distance);
        distance += 200f;
        return Pos;

    }

    public void RandomObject(int objs)
    {
        for (int i = 0; i < objs; i++)
        {
            int objectArray = UnityEngine.Random.Range(0, 13);
            if (!pooledObjects[objectArray].activeInHierarchy)
            {
                pooledObjects[objectArray].transform.position = Position();
                pooledObjects[objectArray].SetActive(true);
            }


        }
    }

    public void SpawnNextObject()
    {
        GameObject obstacle = GetPooledObject();

        if (obstacle != null)
        {
            obstacle.transform.position = Position();
            obstacle.SetActive(true);
        }

    }


    public GameObject GetPooledObject()
    {
        for (int i = 0; i < 14; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
