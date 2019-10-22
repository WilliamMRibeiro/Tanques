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
    float xpos;
    float zpos;
    GameObject anotherClass;
    GameObject anotherGameOb;
    

    void Start()
    {
        
            StartCoroutine(enemyrespawn());
        
    }

    private void Update()
    {
        anotherGameOb = anotherClass;

        float step = speed * Time.deltaTime;
        anotherClass.transform.position = Vector3.MoveTowards(anotherClass.transform.position, player.position, step);
        if (Vector3.Distance(anotherClass.transform.position, player.position) < 0.001f)
        {

            player.position *= -1.0f;

        }
    }

    IEnumerator enemyrespawn()
    {
        while (true)
        {
            xpos = Random.Range(-46, 46);
            zpos = Random.Range(-46, 46);

            GameObject instaenemy = Instantiate(enemySpawn, new Vector3(xpos,0,zpos), Quaternion.identity)  as GameObject;
            anotherClass = instaenemy;
            instaenemy.transform.LookAt(player);
            /*float step = speed * Time.deltaTime;
            instaenemy.transform.position = Vector3.MoveTowards(instaenemy.transform.position, player.position, step);
            if (Vector3.Distance(instaenemy.transform.position, player.position) < 0.001f)
            {

                player.position *= -1.0f;

            }*/


                yield return new WaitForSeconds(respawnTime);
        

        }
    }

    /*private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {

            other.gameObject.SetActive(false);
            Destroy(gameObject);
            
        }
        
    }*/
    
}
