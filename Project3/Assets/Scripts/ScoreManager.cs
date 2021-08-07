/** (Ryan Springer)* 
 * (project 3)* 
 * (tracks player's progress)*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameOver;
    public static bool won;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            textbox.text = "  ";

        }
        if(score == 14)
        {
            won = true;
        }
        if(gameOver)
        {
            if (won)
            {
                textbox.text = "You win! \n press R to retry";
            }
            else
            {
                textbox.text = "You Lose! \n press R to retry";
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
