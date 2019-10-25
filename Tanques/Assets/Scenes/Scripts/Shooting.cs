using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;// define o objeto bala
    public float speed;//velocidade
    public Transform saida;//onde vai sair a bala

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//quando pressionar a tecla espaço
        {
            GameObject instabullet = Instantiate(bullet, saida.position, saida.rotation) as GameObject;//vai criar um clone da bala

            Rigidbody instabulletrb = instabullet.GetComponent<Rigidbody>();//vai adicionar rigidbody

            instabulletrb.velocity = saida.forward * speed;// vai definir o valor da velocidade
        } 
    }
}

