using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickUpWeapon : MonoBehaviour
{
    public Transform hand;
    private itemRotation script;
    public Text dialogue;
    public Image dialogueBox;

    void Start()
    {
        script = this.GetComponent<itemRotation>();//gets a script from the folder of scripts
    }

    private void OnTriggerEnter(Collider other)//once the player touches the weapon it will stop rotating, move to the player's hand and begin the next scene method
    {
        script.enabled = false;
        this.transform.parent = hand.transform;
        StartCoroutine(nextScene());
    }

     IEnumerator nextScene() {//begins next scene of the story
        dialogue.enabled = true;
        dialogueBox.enabled = true;
        dialogue.text = "Now off with ya!";
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("collectionScene", LoadSceneMode.Single);
    }
}
