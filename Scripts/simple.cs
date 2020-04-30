using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simple : MonoBehaviour
{
    public Transform player;
    public Transform alien;
    NavMeshAgent agent;
    Animator anim;
    public GameObject alert;

    public float fieldOfView = 15.0f;
    public float gunRange = 7.5f;

    private bool isAlert = false;
    private int alertCount = 0;
    
    void Start()//sets variables when first starting scene
    {
        this.transform.rotation = Quaternion.identity;
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, alien.position);
        /*
            Cases:
                   1. not alerted and there isn't already an exclamation point
                   2. already alerted and there was already an exclamation point

        */
        if (distance <= fieldOfView)
        {
            if (!isAlert && alertCount == 0)// if the enemy isn't already alerted and there isn't already an exclamation point then...
            {
                alertCount = 1;//increments alert count to signal that there is already one being used
                isAlert = true;
                Vector3 alertPosition = alien.transform.position;// gets enemy's position and places alert point 1.5 units above enemy
                alertPosition.y = alien.transform.position.y + 0.5f;
                Destroy(Instantiate(alert, alertPosition, Quaternion.identity, this.transform), 2.5f);//creates alert point then destroys is 2.5 seconds later
                alertCount = 0;

                distance = Vector3.Distance(player.position, alien.position);// Check again to see if player is still in field of view. If so then go to player
                Debug.Log("starting to wait");
                if (distance <= fieldOfView)
                    agent.SetDestination(player.transform.position);
            }
            else if (isAlert)//if enemy is already alerted then go to player
            {
                agent.SetDestination(player.transform.position);
            }
            
        }
        else// if player isn't in field of view then stay where you are
        {
            agent.SetDestination(alien.transform.position);
            isAlert = false;
        }
    }

    private void OnDrawGizmosSelected()//makes a sphere around the enemy model in the scene view 
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(alien.position, fieldOfView);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(alien.position, gunRange);
    }
}
