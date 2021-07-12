/** (Ryan Springer) * 
 * (Assignment6) * 
 * (triggers win condition) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private bool triggered = false;

    private void nTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            GamePlayManager.gameOver = true;
            GamePlayManager.won = true;
        }
    }
}
