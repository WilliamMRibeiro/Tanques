using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    private float timeLimit = 5f;
    private float timer = 0f;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeLimit)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {

            other.gameObject.SetActive(false);
            Destroy(gameObject);
            

            //contar pontos

            ScoreManager score;

            score = GameObject.Find("Score").GetComponent<ScoreManager>();
            score.Points = 10;

        }



    }
}
