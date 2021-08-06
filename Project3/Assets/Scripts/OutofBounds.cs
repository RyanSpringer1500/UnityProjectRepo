using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutofBounds : MonoBehaviour
{
     void Update()
    {
        if(transform.position.y < -10)
        {
            ScoreManager.gameOver = true;
        }
    }

}
