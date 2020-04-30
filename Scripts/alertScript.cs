using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alertScript : MonoBehaviour
{

    private Transform enemyPosition;
    private Vector3 alertPosition;

    void Start()//will get the enemy's position and place the alert model over the enemy
    {
        enemyPosition = this.transform.parent.transform;
        alertPosition = enemyPosition.transform.position;
        alertPosition.y = enemyPosition.transform.position.y + 1.0f;
        this.transform.position = alertPosition;
        this.transform.Rotate(-90, 0, 0);//makes sure the rotation is correct
    }

    void Update()//places the model .5 units above the enemy
    {
        alertPosition = enemyPosition.transform.position;
        alertPosition.y = enemyPosition.transform.position.y + 0.5f;
        this.transform.position = alertPosition;
    }
}
