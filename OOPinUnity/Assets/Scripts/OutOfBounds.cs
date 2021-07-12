
/** (Ryan Springer) * 
 * (Assignment6) * 
 * (checks if player goes off the plane) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            GamePlayManager.gameOver = true;

        }
    }
}
