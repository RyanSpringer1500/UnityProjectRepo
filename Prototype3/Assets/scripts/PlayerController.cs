﻿/* * (Ryan Springer) *
 * (Assignment4) * 
 * (manages player character) */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float Jumpforce;
    public ForceMode forceMode;
    public ForceMode jumpForceMode;
    public float gravityModifier;
    public Animator playerAnimator;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playAudio;

    public bool isOnGround = true;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetFloat("Speed f", 1.0f);

        playAudio = GetComponent<AudioSource>();

        forceMode = ForceMode.Impulse;
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * Jumpforce, jumpForceMode);
            isOnGround = false;

            playerAnimator.SetTrigger("Jump_trig");

            dirtParticle.Stop();

            playAudio.PlayOneShot(jumpSound, 1.0f);

             
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;

            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
