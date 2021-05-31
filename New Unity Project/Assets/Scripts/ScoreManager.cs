/*
 * (Ryan Springer)
 * (Assignment2)
* (keeps track of scoring and depends the end of the game
 *  
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;
    public Text textbox;
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            textbox.text = "Score:  " + score;
        }
        if( score >= 3)
        {
            won = true;
            gameOver = true;
        }
        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You win! \n Press R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose! \n Press R to Try Again";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }
}
