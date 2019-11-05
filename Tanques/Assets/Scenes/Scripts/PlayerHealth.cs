using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;// imprime o conteudo de vida
    private int health = 10;// define o valor que vai subtrair a vida
    public int Health = 100;// define a vida do jogador
    private void Start()
    {
        healthText.text = "Health: " + Health.ToString();// define a vida do jogador no inicio do jogo
    }

    private void Update()
    {
        gameOver();//chama o gameover
        if (Health <= 0)//se vida for menor ou igual a zero
        {
            Health = 0;// define o valor de vida pra 0
        }

    }
    private void OnTriggerEnter(Collider other)// quando colidir
    {
        if (other.gameObject.tag == "Bullet")//procura a tag Bullet que é a bala
        {
            Health -= health;// diminui 10 do valor de vida para cada bala que atingir o player
            healthText.text = "Health: " + Health.ToString();// escreve na tela o valor de vida
            
        }

        if (other.gameObject.tag == "Life")//procura a tag Bullet que é a bala
        {
            Health += health;// aumenta 10 do valor de vida para cada bala que atingir o player
            healthText.text = "Health: " + Health.ToString();// escreve na tela o valor de vida

        }

    }
    public void gameOver()//game over
    {
        if (Health <= 0)//se vida chegar a zero

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);// troca a cena
            

    }

}
    

