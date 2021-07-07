
/** (Ryan Springer)* 
 * (Assignment5)* 
 * (manages shooting)*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    public ParticleSystem muxzzleFlash;

    public float hitforce = 10f;

    void Update()
    {
      if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }  
    }
    void Shoot()
    {
        muxzzleFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);


            //

            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitforce, ForceMode.Impulse);
            }
        }
    }
}
