using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Finish"))
        {
            ScoreManager.gameOver = true;
            
            //for testing the end goal 
            //ScoreManager.won = true;
        }
    }
}