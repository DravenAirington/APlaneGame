using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public SpawnManager spawnManager;
    public GameObject player;
    public GameMenuManager menuManager;
    public float capSpeed = 100;
    public float startSpeed;
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
    public GameObject[] planes;
    public GameObject UI;
    public GameObject GameOver;


    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject1 = Instantiate(planes[PlayerData.instance.currentPlane], transform);
        GameObject plane = gameObject1;
        DetectCollision detect = plane.GetComponentInChildren<DetectCollision>();
        detect.spawnManager = spawnManager;
        detect.uiCam = UI;
        detect.GOpanel = GameOver;

    }

    // Update is called once per frame
    void Update()
    {
        speed = GameManager.instance.score / 75 + startSpeed;
        boostSpeed = speed + 20;

        if(speed > capSpeed)
        {
            speed = capSpeed;
        }
        //gets the vertical axis to go up and down
        //verticalInput = Input.GetAxis("Vertical");
        //makes it go forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       //makes it go up and downS
        transform.Rotate(Vector3.right * rotationSpeed * vertical * Time.deltaTime);
        //gets horizontal axis
        //horizontalInput = Input.GetAxis("Horizontal");
        //spins left and right
        transform.Rotate(Vector3.back * rotationSpeed * horizontal * Time.deltaTime);
        
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

    public void MoveInput(Vector2 value)
    {
        vertical = value.y;
    }

    public void OnRotate(InputValue value)
    {
        horizontal = value.Get<Vector2>().x;
    }
    public void RotateInput(Vector2 value)
    {
        horizontal = value.x;
    }
    public void OnBoost(InputValue value)
    {
        boost = !boost;
    }
    public void BoostInput(bool value)
    {
        boost = value;
    }
    public void OnFire(InputValue value)
    {
        fire = value.isPressed;
    }
    public void OnPause(InputValue value)
    {
        if(menuManager.isPaused == true)
        {
            menuManager.closePanel();
        }
        else
        {
            menuManager.openPanel();
        }
    }
}
