using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuDialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Image dialogueBox;
    //public Image black;
    //public Animator anim;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()//when the scene begins dialogue UI is disabled
    {
        dialogueText.enabled = false;
        dialogueBox.enabled = false;
        sentences = new Queue<string>();//creates the new string queue to hold the dialogue
    }

    public void startDialogue(dialogue dialogue)// shows dialogue on the text UI
    {
        dialogueBox.enabled = true;//will enable the text UI show that it is now visible as well as clear any previous text
        dialogueText.enabled = true;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
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
        SceneManager.LoadScene("testScene", LoadSceneMode.Single);

    }

}
