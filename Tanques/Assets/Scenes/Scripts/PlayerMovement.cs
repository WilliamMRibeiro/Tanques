using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Movimentacao(moveVertical);

        
        Vector3 movement = new Vector3(0, 0.0f,moveVertical);
        
        // float n_Speed = moveVertical * speed * Time.deltaTime;

        //Vector3 movement = new Vector3(0, 0, n_Speed);

        //rb.MovePosition(rb.position + movement);
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        Quaternion rot = Quaternion.Euler(new Vector3(0, moveHorizontal, 0));

        rb.MoveRotation(rb.rotation * rot);
    }

    void Movimentacao(float vertical)
    {
        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;

        rb.MovePosition(rb.position + movement);
    }
}

