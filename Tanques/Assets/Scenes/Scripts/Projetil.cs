using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    private float timeLimit = 5f;//define valor limite de tempo
    private float timer = 0f;//define valor
    
    void Update()
    {
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

        if (other.gameObject.tag == "Enemy")//procura o inimigo

        {

            other.gameObject.SetActive(false);//destroi o inimigo
            Destroy(gameObject);//destroi a bala
            
            ScoreManager score;//guarda os pontos

            score = GameObject.Find("Score").GetComponent<ScoreManager>();//encontra o componente score
            score.Points = 10;// adiciona 10 cada vez que acerta um inimigo

        }
    }
}
