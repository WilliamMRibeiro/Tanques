using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbehavior : MonoBehaviour
{
    public float speed;
    public float timer;
    public float timeLimit;



    private void Update()
    {
        transform.Rotate(0, -speed, 0);
        timer += Time.deltaTime;//soma o tempo

        if (timer >= timeLimit)//condição pra verificação
        {
            timer = 0;//reseta timer
            Destroy(gameObject);//destroi o clone da bala
        }

    }
    private void OnTriggerEnter(Collider other)//quando colidir
    {
        if (other.gameObject.tag == "Player")//procura a tag player

        {

            Destroy(gameObject);//destroi a bala

        }
    }
}

