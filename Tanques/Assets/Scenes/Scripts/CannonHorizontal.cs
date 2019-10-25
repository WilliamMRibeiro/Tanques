using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonHorizontal : MonoBehaviour
{
    public float speed; // variavel de velocidade que define a velocidade da rotação

    
    void Update()
    {

        Vector3 horizontal = new Vector3(0, speed * Time.deltaTime, 0); //variavel de posição 

        if (Input.GetKey(KeyCode.Keypad4))// faz a rotação do canhão na tecla 4 
        {
            transform.Rotate(-horizontal);// faz a rotação acontecer

        }
        if (Input.GetKey(KeyCode.Keypad6))// faz a rotação do canhao na tecla 6
        {
            transform.Rotate(horizontal);// faz a rotação acontecer
        }

        
    }
}
