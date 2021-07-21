/* * (Ryan Springer) 
 * * (project2) 
 * * (destory's game object after collison) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBeGone : MonoBehaviour
{
    [Header("References")]
    public GameObject TrashVisuals;
    public GameObject collectedParticleSystem;
    public CircleCollider2D TrashCollider2D;

    private float durationOfCollectedParticleSystem;


    

    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            TrashCollected();
           
        }
    }

    void TrashCollected()
    {
        TrashCollider2D.enabled = false;
        TrashVisuals.SetActive(false);
        collectedParticleSystem.SetActive(true);
        Invoke("DeactivateGemGameObject", durationOfCollectedParticleSystem);

    }

    void DeactivateGemGameObject()
    {
        gameObject.SetActive(false);
    }
}
