using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    void Update()//makes laser fall to the ground
    {
        if (this.transform.position.y <= -1)
            Destroy(gameObject);
    }
}
