using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonHorizontal : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*float mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        transform.Rotate(0, mouseX, 0);*/

        Vector3 horizontal = new Vector3(0, speed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.Rotate(-horizontal);

        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.Rotate(horizontal);
        }

        
    }
}
