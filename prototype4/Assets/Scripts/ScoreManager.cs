/* * (Ryan Springer) * 
 * (Assignment7) * 
 * (displays score and determins game over state) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Wave:  " + SpawnManager.waveCount;
        }
        if (SpawnManager.waveCount >= 10)
        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Won! \n Press R to Try Again";
            }
            else
            {
                textbox.text = "You Lose!  \n Press R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }

    }
}
