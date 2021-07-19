/* * (Ryan Springer) * 
 * (Assignment7) * 
 * (removes bottom text) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DestoryText : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            textbox.text = " ";
        }
    }
}
