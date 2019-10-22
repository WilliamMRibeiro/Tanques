using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotatespeed;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        rb.velocity = transform.forward * speed * moveTank *Time.deltaTime;
        
        transform.Rotate(Vector3.up * rotatespeed * rotateTank * Time.deltaTime);
    }
       
}

