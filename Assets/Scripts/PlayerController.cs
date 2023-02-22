using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public SpawnManager spawnManager;
    public GameObject player;
    public GameObject propeller;
    public float propellerSpeed;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float spinInput;
    public float boostSpeed;
    public float horizontal;
    public float vertical;
    public bool boost;
    public bool fire;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward * propellerSpeed);
        //gets the vertical axis to go up and down
        //verticalInput = Input.GetAxis("Vertical");
        //makes it go forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       //makes it go up and downS
        transform.Rotate(Vector3.right * rotationSpeed * vertical);
        //gets horizontal axis
        //horizontalInput = Input.GetAxis("Horizontal");
        //spins left and right
        transform.Rotate(Vector3.back * rotationSpeed * horizontal);
        
        //uses quaternions to adjust back to zero
        /*if (Input.GetButton("Readjust"))
        {
            player.transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, Quaternion.Euler(Vector3.zero), Time.deltaTime * 2f);
        }*/
        //press e to boost
        if (boost)
        {
            transform.Translate(Vector3.forward * boostSpeed * Time.deltaTime);
        }
        
        
    }

    

    public void OnMove(InputValue value)
    {
        vertical = value.Get<Vector2>().y;  
    }
    public void OnRotate(InputValue value)
    {
        horizontal = value.Get<Vector2>().x;
    }
    public void OnBoost(InputValue value)
    {
        boost = !boost;
    }
    public void OnFire(InputValue value)
    {
        fire = value.isPressed;
    }
}
