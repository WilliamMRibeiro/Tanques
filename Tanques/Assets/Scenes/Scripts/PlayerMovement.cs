using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotatespeed = 50.0f;
    

    
    
    void FixedUpdate()
    {
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * speed * moveTank;

        transform.Rotate(Vector3.up * rotatespeed * rotateTank * Time.deltaTime);
    }
       
}

