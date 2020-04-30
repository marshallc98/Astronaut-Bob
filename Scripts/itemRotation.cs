using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRotation : MonoBehaviour
{
    public float heightChange;
    Vector3 position;

    void Start()//decides where the model will go
    {
        position = this.transform.position;
        position.y = this.transform.position.y + heightChange;
        transform.position = position;
    }

    void Update()//will rotate the model that is connected to this script
    {
        this.transform.Rotate(0, 45 * Time.deltaTime, 0);
    }
}
