using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;

    public void triggerDialogue()//starts the dialogue if player enters range of tower
    {
        FindObjectOfType<dialogueManager>().startDialogue(dialogue);
    }
}
