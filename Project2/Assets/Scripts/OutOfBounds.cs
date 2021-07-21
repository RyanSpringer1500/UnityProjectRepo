/* * (Ryan Springer) 
 * * (project2) 
 * * (player loss condition) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OutOfBounds : MonoBehaviour
{
    public Text textBox;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5)
        {
            textBox.text = "You lose! \n Press R to try Again";
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
