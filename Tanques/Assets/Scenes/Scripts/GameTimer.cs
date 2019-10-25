using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
    

public class GameTimer : MonoBehaviour
{
    public float timer = 60f;// segundos que o contador vai começar

    public Text TimeText;// texto para publicar no canvas

    private void Update()
    {
        timer -= Time.deltaTime;//diminui os segundos
        TimeText.text = timer.ToString("Timer: 00:00");//publica na tela o tempo

        if (timer <= 0)//quando o tempo acabar
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);// troca a cena
        }
    }
    
}
