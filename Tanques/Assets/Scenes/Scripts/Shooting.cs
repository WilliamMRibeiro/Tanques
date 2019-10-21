using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10f;
    public Transform saida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instabullet = Instantiate(bullet, saida.position, saida.rotation) as GameObject;
            Rigidbody instabulletrb = instabullet.GetComponent<Rigidbody>();
            instabulletrb.velocity = speed * Time.deltaTime * saida.forward;
        } 
    }
}

