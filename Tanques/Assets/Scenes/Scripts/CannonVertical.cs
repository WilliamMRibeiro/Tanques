using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonVertical : MonoBehaviour
{
    public float speed = 10;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        //transform.Rotate(-mouseY, 0, 0);
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }

    }
}
