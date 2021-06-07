/*
 * (Ryan Springer
 * (Assignment3)
 * (allows player to shoot dogs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //attempt to prevent the player from spamming space bar
            //WaitForSeconds(3.0f);
        }
    }
}
