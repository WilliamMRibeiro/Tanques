using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDisable()
    {
        Destroy(gameObject);//destroy o clone do inimigo
    }
   
}
