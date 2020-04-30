using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemManager : MonoBehaviour
{
    public Text itemsRemaining;
    public int numberOfItems = 4;

    private void Start()//UI of items initialized when scene is started
    {
        itemsRemaining.text = "Items Remaining: " + numberOfItems;
    }

    private void OnTriggerEnter(Collider other)//will destroy the item if colliding with player and decreases number of items
    {

        Destroy(gameObject);
        itemsRemaining.text = "Items Remaining: " + --numberOfItems;
    }
}
