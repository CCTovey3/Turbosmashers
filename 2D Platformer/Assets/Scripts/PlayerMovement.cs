using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(0, 0, Input.GetAxis("Horizontal")*-0.25f);

        if(Input.GetKeyDown(KeyCode.JoystickButton0))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*5f, ForceMode2D.Impulse);
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
            GetComponent<Rigidbody2D>().AddForce(Vector2.left, ForceMode2D.Impulse);
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
            GetComponent<Rigidbody2D>().AddForce(Vector2.right, ForceMode2D.Impulse);

    }
}
