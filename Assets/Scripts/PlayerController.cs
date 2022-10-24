using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject propeller;
    public float propellerSpeed;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float spinInput;
    public float boostSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward * propellerSpeed);
        //gets the vertical axis to go up and down
        verticalInput = Input.GetAxis("Vertical");
        //makes it go forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       //makes it go up and downS
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput);
        //gets horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        //spins left and right
        transform.Rotate(Vector3.back * rotationSpeed * horizontalInput);
        
        
        if (Input.GetButton("Readjust"))
        {
            player.transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, Quaternion.Euler(Vector3.zero), Time.deltaTime * 2f);
        }

        if (Input.GetButton("Boost"))
        {
            transform.Translate(Vector3.forward * boostSpeed * Time.deltaTime);
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
