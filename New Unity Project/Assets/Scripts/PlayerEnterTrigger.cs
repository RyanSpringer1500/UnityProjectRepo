/*
* (Ryan Springer)
 * (Assignment2)
* (detects when the player runs into a trigger
 *  
		 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to player

public class PlayerEnterTrigger : MonoBehaviour
{
    //set this reference in the inspector
 
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
