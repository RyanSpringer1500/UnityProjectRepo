/* * (Ryan Springer) *
 * (Assignment4) * 
 * (manages text) */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public PlayerController PlayerControllerScript;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if(PlayerControllerScript == null)
        {
            PlayerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerControllerScript.gameOver)
        {
            scoreText.text = "Score:   " + score;
        }
        if(PlayerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose! \n Press R to Try Again!";
        }
        if(score >= 10)
        {
            PlayerControllerScript.gameOver = true;
            won = true;
            scoreText.text = "You Win! \n Press R to Try Again!";
        }
        if(PlayerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
