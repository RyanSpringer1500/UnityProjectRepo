/* * (Ryan Springer) 
 * * (project2) 
 * * (player win condition) */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TriggerGoal : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("TriggerPoint"))
        {
            score++;
        }
        if (score == 2)
        {
            if (other.CompareTag("TriggerZone"))
            {
                textbox.text = "You win! \n Press R to try again";
            }
        }
        
    }
}
