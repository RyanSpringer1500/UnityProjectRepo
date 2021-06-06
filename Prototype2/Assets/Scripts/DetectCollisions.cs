/*
 * (Ryan Springer
 * (Assignment3)
 * (detects when a game objects hits another game object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;
   private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScore").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
