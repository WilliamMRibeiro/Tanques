using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    

public class GameTimer : MonoBehaviour
{
    public float timer = 60f;

    public Text TimeText;

    private void Update()
    {
        timer -= Time.deltaTime;
        TimeText.text = timer.ToString("Timer: 00:00");
    }
}
