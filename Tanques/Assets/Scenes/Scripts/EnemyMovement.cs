using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //inimigo siga o player

    private Transform player;// posição do objeto que o inimigo vai seguir
    public float speed;// variavel de velocidade
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();//define o valor do posicionamento do player para o inimigo seguir
    }

    private void Update()
    {
        
        float step = speed * Time.deltaTime;// velocidade

        transform.position = Vector3.MoveTowards(transform.position, player.position, step);// faz o inimigo seguir o player
        transform.LookAt(player, Vector3.up);// aponta o inimigo para a direção do jogador
        
    }
}
