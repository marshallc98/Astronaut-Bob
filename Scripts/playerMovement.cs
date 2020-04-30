using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;
    Camera cam;
    Rigidbody rb;
    CharacterController character;
    private Vector3 direction, rotation;//direction the player is facing and rotation of the camera
    private float jumpHeight = 8.0f;
    private float forwardDirection;

    public Text itemsRemaining;
    private int numOfItems = 4;


    void Start()
    {
        rb = GetComponent<Rigidbody>();//gets player's RigidBody
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();//gets navMesh to control animations
        anim = GetComponent<Animator>();//gets the animator that is controling the player
        character = GetComponent<CharacterController>();

        itemsRemaining.text = "Items Remaining: " + numOfItems;
    }
    private void FixedUpdate()
    {
        rotation.y = cam.transform.eulerAngles.y;//gets the rotation of the camera and sets the players rotation to the same to give the first person point of view
        transform.eulerAngles = rotation;

        if (Input.GetKey(KeyCode.W))//forward
        {
            forwardDirection = 1;
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.S))//backward
        {
            forwardDirection = -1;
            anim.SetBool("isWalking", true);
        }
        else//don't move at all
        {
            forwardDirection = 0;
            anim.SetBool("isWalking", false);
        }
       
        if (Input.GetKey(KeyCode.LeftShift))//checks to see if user wants to sprint and changes the player's speed
        {
            character.Move(forwardDirection * transform.forward * Time.deltaTime * 3.5f);//sprinting speed of player
            anim.SetBool("isRunning", true);//sets animation to play 
        }
        else
        {
            character.Move(forwardDirection * transform.forward * Time.deltaTime * 1.5f);//walking speed of player
            anim.SetBool("isRunning", false);
        }

        //////////////////////////////

        if (numOfItems == 0)//once the player collects all of the parts then the next scene will load with max health
            SceneManager.LoadScene("runToShip", LoadSceneMode.Single);
        
    }
    private void OnTriggerEnter(Collider other)// checks for the player to get close enough to a part to collect it and update UI
    {
        if (other.transform.tag == "item")
        {
            Destroy(other.gameObject);
            itemsRemaining.text = "Items Remaining: " + --numOfItems;
        }
    }
}
