/*
 * (Ryan Springer
 * (Assignment3)
 * (allows player to shoot food projectiles 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabShoot, transform.position, prefabShoot.transform.rotation);
        }
        
    }
}
