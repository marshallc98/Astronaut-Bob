using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    void Update()//will have the camera continue to rotate at the main menu
    {
        transform.Rotate(0.0f, 10.0f * Time.deltaTime, 10.0f * Time.deltaTime, Space.Self);
    }
}
