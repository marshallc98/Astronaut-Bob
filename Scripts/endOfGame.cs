using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endOfGame : MonoBehaviour
{
    public endManager manager;
    public dialogue dialogue;
    private int alreadyCollided = 0;

    private void OnTriggerEnter(Collider other)//waits for player to get close to rocket to end the game and start endgame dialogue
    {
        if (alreadyCollided == 0)
        {
            manager.startDialogue(dialogue);
            alreadyCollided++;
        }
    }
}
