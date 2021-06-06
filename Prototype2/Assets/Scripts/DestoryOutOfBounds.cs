/*
 * (Ryan Springer
 * (Assignment3)
 * (Prevents game objects from going out of player's view
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
        
    }
}
