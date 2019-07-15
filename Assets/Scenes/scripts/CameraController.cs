using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   //public means any script can access it
   public GameObject player;
   

   //public means we can set the value in this script and it won't be accesible from elsewhere
   private Vector3 offset;

   void Start()
    {
        //would equal zero at start 
	offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     transform.position = player.transform.position + offset;
    }
}
