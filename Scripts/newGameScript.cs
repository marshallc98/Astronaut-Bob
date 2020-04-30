using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newGameScript : MonoBehaviour
{
    public menuDialogueManager manager;
    public dialogue text;
    public Canvas menuCanvas;
    public Canvas dialogueCanvas;
    //public Animator anim;

    private void Start()//hides the dialogue box in the UI
    {
        dialogueCanvas.enabled = false;
    }

    public void startGame() {//enables/disables canvas' when start button is clicked
        menuCanvas.enabled = false;
        dialogueCanvas.enabled = true;
        manager.startDialogue(text);
        //SceneManager.LoadScene("testScene", LoadSceneMode.Single);
    }
    

    private void Awake()
    {
        this.GetComponentInChildren<Text>().text = "New Game";
        
    }
}
