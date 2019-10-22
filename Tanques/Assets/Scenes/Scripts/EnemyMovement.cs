using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //inimigo siga o player
    private Transform player;
    public float speed = 10.0f;
    const float distancia = 0.1f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        /*transform.LookAt(player);
        if ((transform.position - player.position).magnitude > distancia)
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }*/
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        transform.LookAt(player, Vector3.up);
        if (Vector3.Distance(transform.position, player.position) < 0.001f)
        {

            player.position *= -1.0f;

        }
    }
}
