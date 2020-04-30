using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealth;
    private float currHealth;

    public Text text;
    public GameObject restart;//button to restart the scene
    public GameObject menu;//button to go to the main menu

    void Start()
    {
        Cursor.visible = false;//the cursor won't be visible
        restart.SetActive(false);//buttons won't be active
        menu.SetActive(false);
        healthSlider.maxValue = maxHealth;//restarts health to max health.
        currHealth = maxHealth;        
    }
    private void Update()//continually looks to see if the health is 0 and if so will enable buttons and cursor
    {
        currHealth = healthSlider.value;

        if(currHealth == 0)
        {
            Cursor.visible = true;
            restart.SetActive(true);
            menu.SetActive(true);
            text.text = "Game over... Restart?";
        }

    }
    private void OnTriggerEnter(Collider other)//if touched by enemy then health will decrease
    {
        if(other.tag == "enemy")
            healthSlider.value = healthSlider.value - 1;
    }
}
