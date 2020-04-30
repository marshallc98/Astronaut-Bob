using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    public void restartScene() {//gets current scene and starts it again
        SceneManager.LoadScene("collectionScene", LoadSceneMode.Single);
    }
}
