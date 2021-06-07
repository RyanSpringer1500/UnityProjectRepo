/*
 * (Ryan Springer
 * (Assignment3)
 * (detects collision between ball and dogs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("displayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;

        Destroy(gameObject);
    }
}
