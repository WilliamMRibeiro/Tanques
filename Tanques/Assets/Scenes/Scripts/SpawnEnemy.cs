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
    public float respawnTime;
        
    float xpos;
    float zpos;
        
    void Start()
    {
        StartCoroutine(enemyrespawn());
    }
        
    IEnumerator enemyrespawn()
    {
        while (true)
        {
            xpos = Random.Range(-46, 46);
            zpos = Random.Range(-46, 46);

            GameObject instaenemy = Instantiate(enemySpawn, new Vector3(xpos, 0, zpos), Quaternion.identity) as GameObject;
            instaenemy.transform.LookAt(player);
            
            yield return new WaitForSeconds(respawnTime);


        }
    }
}
