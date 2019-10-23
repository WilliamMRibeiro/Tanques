using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 35f;
    public Transform saida;
    public float timer;
    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeLimit)
        {
            timer = 0;
            Shoot();
                        
        }
    }
    // Update is called once per frame
    void Shoot()
    { 
        
        GameObject instabullet = Instantiate(bullet, saida.position, saida.rotation) as GameObject;
        Rigidbody instabulletrb = instabullet.GetComponent<Rigidbody>();
        instabulletrb.velocity = saida.forward * speed;

    }
    
}

