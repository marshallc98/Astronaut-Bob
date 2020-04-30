using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathMenu : MonoBehaviour
{
    public void goToMenu()//will go to menu if button is clicked
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);

    }
}
