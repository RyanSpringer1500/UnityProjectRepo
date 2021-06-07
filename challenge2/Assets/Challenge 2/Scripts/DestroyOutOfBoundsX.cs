/*
 * (Ryan Springer
 * (Assignment3)
 * destorys gameobjects when going out of character's view
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit\
        // an attempt to change this the greater than sign causes the game to have issues running for me
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }

    }
}
