using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //Fazer o objeto nascer em um ponto especifico
    //instanciar em um tempo especifico
    //objeto seguir o jogador
    //objeto atirar no jogador
    //objeto se destruir

    public GameObject enemySpawn;
    public Transform player;
    public Transform spawn;
    public float respawnTime = 1.0f;
    public float speed = 10.0f;
    const float distancia = 0.1f;
    


    void Start()
    {
                StartCoroutine(enemyrespawn());
    }
    
    private void respawn()
    {
       
              GameObject instaenemy = Instantiate(enemySpawn, spawn.position, spawn.rotation) as GameObject;

        instaenemy.transform.LookAt(player);
        if ((instaenemy.transform.position - player.position).magnitude > distancia)
        {
            instaenemy.transform.Translate(0f, 0f, speed * Time.deltaTime);
        }



    }
    
    IEnumerator enemyrespawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
        respawn();

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {

            other.gameObject.SetActive(false);
            Destroy(gameObject);
            
        }
        
    }
    
}
