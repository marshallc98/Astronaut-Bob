using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public GameObject cavern;
    public GameObject collection;
    public GameObject running;

    public GameObject newGame;
    public GameObject exit;
    public GameObject back;
    /*
     * 
     * Each method is for a button. 
     * Depending on the button will go to another scene or restart current scene
     * 
     * It also keeps track of enabling/disabling buttons needed/not needed
     * 
     * 
     * 
     */

    public void goToMenu()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);

    }

    public void restartScene()
    {
        Scene currScene = SceneManager.GetActiveScene();
        string sceneName = currScene.name;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void loadCavern() {
        SceneManager.LoadScene("crystalCavern", LoadSceneMode.Single);
    }
    public void loadCollection()
    {
        SceneManager.LoadScene("collectionScene", LoadSceneMode.Single);
    }
    public void loadRun()
    {
        SceneManager.LoadScene("runToShip", LoadSceneMode.Single);
    }
    public void exitGameFunction()//if project is built then this function will work. However, when using Unity this function won't work and won't close application
    {
        Application.Quit();
    }
    public void backButton()
    {
        back.SetActive(false);
        cavern.SetActive(false);
        collection.SetActive(false);
        running.SetActive(false);
        newGame.SetActive(true);
        exit.SetActive(true);
    }
}
