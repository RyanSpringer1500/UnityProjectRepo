/** (Ryan Springer)* 
 * (project 3)* 
 * (destorys trash when pick up by player)*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashPickUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            ScoreManager.score++;
            Destroy(gameObject);
        }
    }
}
