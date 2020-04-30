using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;//the player's transform

    public float yaw = 0.0f;
    public float pitch = 0.0f;
    public float heightChange = 1.5f;

    public float speedH = 2.0f, speedV = 2.0f;

    private void Start()
    {
        Cursor.visible = false;//hides the cursor
    }
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + heightChange, player.position.z);//changes the position of the camera to the player's head

        yaw += speedH * Input.GetAxis("Mouse X");//finds where the mouse is for X and Y coordinates
        pitch -= speedV * Input.GetAxis("Mouse Y");

        pitch = Mathf.Clamp(pitch, -15f, 64f);//sets a range of angles the camera can look so that it isn't looking through the player

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);//changes the angle of the camera 
    }
}
