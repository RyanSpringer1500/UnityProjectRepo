/*
 * (Ryan Springer
 * (Assignment3)
 * (Allows player to control their character on screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horiztonalInput;
    public float speed = 10.0f;
    private float xRange = 14; 
  

    // Update is called once per frame
    void Update()
    {
        horiztonalInput = Input.GetAxis("Horiztonal");

        transform.Translate(Vector3.right * horiztonalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
    }
}
