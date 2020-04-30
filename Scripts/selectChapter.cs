using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectChapter : MonoBehaviour
{
    public GameObject cavern;
    public GameObject collection;
    public GameObject running;

    public GameObject newGame;
    public GameObject exit;
    public GameObject back;

    /*
     * When the scene first starts then needed buttons will be enabled and others disabled
     * 
     * When displaying chapters will disable/enable buttons
     */


    private void Awake()
    {
        back.SetActive(false);
        cavern.SetActive(false);
        collection.SetActive(false);
        running.SetActive(false);
        newGame.SetActive(true);
        exit.SetActive(true);
    }
    public void displayChapters() {
        back.SetActive(true);
        cavern.SetActive(true);
        collection.SetActive(true);
        running.SetActive(true);
        newGame.SetActive(false);
        exit.SetActive(false);

    }
}
