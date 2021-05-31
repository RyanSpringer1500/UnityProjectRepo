/*
* (Ryan Springer)
 * (Assignment2)
 * (detect when player goes out of bounds when playing.
 *  
		 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossIfOutOfBounds : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if(80 < transform.position.y)
        {
            ScoreManager.gameOver = true;
        }
        if(transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
