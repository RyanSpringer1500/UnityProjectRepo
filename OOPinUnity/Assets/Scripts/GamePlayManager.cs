/** (Ryan Springer) * 
 * (Assignment6) * 
 * (determines if player wins) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
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
        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You win! \n Press R to Try Again";
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
