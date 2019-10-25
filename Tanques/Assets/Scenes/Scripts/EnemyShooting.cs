using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;// porder selecionar o prefab que será a bala
    public float speed = 35f;// velocidade do tiro
    public Transform saida;// lugar onde vai sair o tiro
    public float timer;// define o tempo
    public float timeLimit;// define o limite de tempo

   
    void Update()
    {
        timer += Time.deltaTime;// controla os frames

        if (timer >= timeLimit)// define a condição pro inimigo atirar
        {
            timer = 0;//reseta o timer

            Shoot();// faz o tiro
        }
    }
    
    void Shoot()//faz atirar
    { 
        GameObject instabullet = Instantiate(bullet, saida.position, saida.rotation) as GameObject;//cria a bala como um gameobject
        Rigidbody instabulletrb = instabullet.GetComponent<Rigidbody>();//adicionar rigidbody a bala
        instabulletrb.velocity = saida.forward * speed;// faz a bala ir pra frente
    }
    
}

