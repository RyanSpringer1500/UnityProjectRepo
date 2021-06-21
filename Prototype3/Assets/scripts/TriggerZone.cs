/* * (Ryan Springer) *
 * (Assignment4) * 
 * (updates score) */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }

   
}
