using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    private float timeLimit = 5f;
    private float timer = 0f;
    public float speed = 10.0f;
    public float rotatespeed = 50.0f;
    public Transform saida;
    Rigidbody rb;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeLimit)
        {
            
            
                float rotateTank = 10f;
                float moveTank = 50f;

                GameObject instaenemy = Instantiate(enemy, saida.position, saida.rotation) as GameObject;
                Rigidbody instenemytrb = instaenemy.GetComponent<Rigidbody>();
                rb.velocity = transform.forward * speed * moveTank * Time.deltaTime;

                transform.Rotate(Vector3.up * rotatespeed * rotateTank * Time.deltaTime);
            
            timer = 0;
            Destroy(gameObject);
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
