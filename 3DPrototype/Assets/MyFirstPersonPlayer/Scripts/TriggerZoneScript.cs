/** (Ryan Springer)* 
 * (Assignment5)* 
 * (Ziggers goal)*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerZoneScript : MonoBehaviour
{
    public Text textbox;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            textbox.text = "You win!";
        }
    }

}
