/* * (Ryan Springer) 
 * * (Assignment5) 
 * * (player interaction with end goal gem) */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class TriggerZoneGoal : MonoBehaviour
{
    //private bool triggered = false;
    public static int score = 0;
    public Text textbox;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    
    
        if(collision.CompareTag("TriggerZone"))
        {

            //triggered = true;
            textbox.text = "You win!  Score:" + score;
           
        }
    }
   
}
