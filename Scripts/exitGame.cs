using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        this.GetComponentInChildren<Text>().text = "Exit";
    }


    // Update is called once per frame
    public void exitGameFunction() {
        Application.Quit();
    }
}
