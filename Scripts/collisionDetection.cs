using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetection : MonoBehaviour
{
    Collider collider;
    public dialogueManager manager;//manages what the dialogue will do
    public dialogue dialogue;
    private int alreadyCollided;//to decide if the player already collided with sphere
    void Start()
    {
        collider = GetComponent<Collider>();
        alreadyCollided = 0;
        
    }

    private void OnTriggerEnter(Collider other)//once the player gets in range it will begin dialogue and make sure it doesn't rerun dialogue over and over
    {
        if (alreadyCollided == 0)
        {
            manager.startDialogue(dialogue);
            alreadyCollided++;
        }
       
    }
    private void OnDrawGizmosSelected()//draws sphere of range
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 15.0f);
    }

}
