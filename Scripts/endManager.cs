using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endManager : MonoBehaviour
{
    public Text dialogueText;
    public Image dialogueBox;

    private Queue<string> sentences;

    void Start()
    {
        dialogueBox.enabled = false;//makes sure the user can't see the box and text yet
        dialogueText.enabled = false;
        sentences = new Queue<string>();//holds all of the sentences 
    }

    public void startDialogue(dialogue dialogue) {//begins the dialogue 
        dialogueBox.enabled = true;//box and text can now be seen in the gameplay.
        dialogueText.enabled = true;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)//will put all of the sentences from the dialogue into the queue
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()//displays all the sentences
    {
        if (sentences.Count == 0)
        {//if there are no more sentences in the queue then will end the dialogue
            EndDialogue();
            return;
        }

        string currentSentence = sentences.Dequeue();//gets the next sentence on the queue
        //dialogueText.text = currentSentence;
        StopAllCoroutines();
        StartCoroutine(LetterFunc(currentSentence));//creates the "animation" of the letters appearing one after another 
    }

    IEnumerator LetterFunc(string sentence)//takes current sentence and creates letter animation
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(2.0f);//waits 2 seconds once the current sentence is complete to give player time to read 
        DisplayNextSentence();
    }

    public void EndDialogue()
    {//ends dialogue by disabling and starting next scene
        dialogueBox.enabled = false;
        dialogueText.enabled = false;
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);

    }
}
