/*
* (Ryan Springer)
 * (Assignment2)
 * keeps track of the car going off road
 * 
		 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{
   
   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
