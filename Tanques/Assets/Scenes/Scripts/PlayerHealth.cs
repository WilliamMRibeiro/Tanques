using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;
    private int health = 10;
    public int Health = 100;

    private void Start()
    {
        healthText.text = "Health: " + Health.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health = Health -health;
            healthText.text = "Health: " + Health.ToString();
            
        }

    }
    
}
    

