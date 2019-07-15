using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public means any script can access it
    public GameObject player;

    //public means we can set the value in this script and it wont be accessible from elsewheree
    private Vector3 offset;

    void Start()
    {
        //would equal zero at start
        offset = transform.position - player.transform.position;
    }

    //LateUpdate runs last but every frame, we want this since the camera is following after the keystroke(input) has been processed
    void LateUpdate()
    {
        //as we move, the camera is moved into a new position aligned to the player object
        transform.position = player.transform.position + offset;
    }
}
