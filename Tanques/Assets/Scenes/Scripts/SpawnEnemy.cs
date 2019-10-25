using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //Fazer o objeto nascer em um ponto especifico
    //instanciar em um tempo especifico
  
    public GameObject enemySpawn;//define o objeto que vai fazer o renascer
    public Transform player;//referencia do player
    public Transform spawn;//referencia do lugar onde nascer
    public float respawnTime;//tempo de renascer
        
    float xpos;//define as coordenadas de x
    float zpos;//define as coordenadas de z
        
    void Start()
    {
        StartCoroutine(enemyrespawn());//começã a função que pelo que eu entendi não para nunca. kkkk
    }
        
    IEnumerator enemyrespawn()//vai fazer a verificação 
    {
        while (true)//define como sempre verdade
        {
            xpos = Random.Range(-46, 46);//define a posição de forma aleatoria
            zpos = Random.Range(-46, 46);//define a posição de forma aleatoria

            GameObject instaenemy = Instantiate(enemySpawn, new Vector3(xpos, 0, zpos), Quaternion.identity) as GameObject;//cria a copia do inimigo
            instaenemy.transform.LookAt(player);//faz ele nascer e "olhar" pro player
            
            yield return new WaitForSeconds(respawnTime);//tempo que esse função vai demorar para se repetir


        }
    }
}
