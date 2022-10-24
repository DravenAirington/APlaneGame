using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    List<GameObject> objectList = new List<GameObject>();
   private float distance = 200f;
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;
    public GameObject Obj4;
    public GameObject ohObj1;
    public GameObject ohObj2;
    public GameObject ohObj3;
    public GameObject ohObj4;
    public GameObject mhObj;
    public GameObject objRando;
    public GameObject objRando2;
    public GameObject objRando3;
    public GameObject objRando4;
    public GameObject objRando5;
    // Start is called before the first frame update
    void Start()
    {
        objectList.Add(Obj1);
        objectList.Add(Obj2);
        objectList.Add(Obj3);
        objectList.Add(Obj4);
        objectList.Add(ohObj1);
        objectList.Add(ohObj2);
        objectList.Add(ohObj3);
        objectList.Add(ohObj4);
        objectList.Add(mhObj);
        objectList.Add(objRando);
        objectList.Add(objRando2);
        objectList.Add(objRando3);
        objectList.Add(objRando4);
        objectList.Add(objRando5);
        RandomObject(10);
        
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
            int objectArray = UnityEngine.Random.Range(0, 8);
            Instantiate(objectList[objectArray], Position(), objectList[objectArray].transform.rotation);
          }
    }
}
