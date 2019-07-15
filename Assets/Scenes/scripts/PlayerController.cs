
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement*20);
    }
//other means that when Collider touches an other item, then we do this.
//The sample code for OnTriggerEnter in the Unity docs use destroy object
    void OnTriggerEnter(Collider other)
    {

//If the other object has Pick Up as a tag
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //SetActive basically unchecks the box and makes it hide
            other.gameObject.SetActive(false);
        }

    }

}