using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;// define o valor de velocidade
    public float rotatespeed;// define o valor de rotação

    Rigidbody rb;// variaval para o rigidbody

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();// adiciona o ridigbody
    }


    void FixedUpdate()
    {
        float rotateTank = Input.GetAxis("Horizontal");//adiciona valores que são acionados pelo player
        float moveTank = Input.GetAxis("Vertical");// adiciona valores que são acionados pelo player

        rb.velocity = transform.forward * speed * moveTank *Time.deltaTime;//define a velocidade do tanque
        
        transform.Rotate(Vector3.up * rotatespeed * rotateTank * Time.deltaTime);// define a velocidade da rotação do tanque
    }
       
}

