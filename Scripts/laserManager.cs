using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserManager : MonoBehaviour
{
    public GameObject laser;
    public Camera mainCamera;


    void Start()
    {
        StartCoroutine(spawnLasers());
    }

    IEnumerator spawnLasers() {//will continually spawn lasers
        while (true) {
            yield return new WaitForSeconds(0.75f);//every 0.75 seconds a laser will be created
            Vector3 position = new Vector3(Random.value, 1.3f, 5.0f); //create laser random x in camera view, 1.3 units above the camera, 5.0 units in front of the player

            position = Camera.main.ViewportToWorldPoint(position);//will decide where the laser will spawn

            Instantiate(laser, position, laser.transform.rotation);//takes the laser model and copies it to location
        }
    }

}
