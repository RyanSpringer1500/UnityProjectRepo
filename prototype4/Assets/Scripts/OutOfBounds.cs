/* * (Ryan Springer) * 
 * (Assignment7) * 
 * (check if player went out of bounds and declares game loos) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    
    void Update()
    {
        if(transform.position.y < 0)
        {
            ScoreManager.gameOver = true;
        }
    }
}
