/* * (Ryan Springer) *
 * (Assignment4) * 
 * (Moves the camera and bacakground left) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    public float leftBound = -15;
    private PlayerController PlayerControllerScript;

    private void Start()
    {
        PlayerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        
    }
}
