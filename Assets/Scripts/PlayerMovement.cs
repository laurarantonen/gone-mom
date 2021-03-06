﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;


public class PlayerMovement : MonoBehaviour
{
    public AudioSource runningSound;
    public AudioSource playerSound1;
    public AudioSource playerSound2;
    public bool canMove;
    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    private int random;

    private Animator anim;

    // Called after all objects are initialized.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component
        anim = GetComponent<Animator>();
        runningSound = GetComponent<AudioSource>();
        canMove = true;

        PlaySounds();
    }

    public void PlaySounds()
    {
        if (SceneManager.GetActiveScene().name == "Toys")
        {
            return;
        }
        
        random = UnityEngine.Random.Range(1, 5);
        Debug.Log(random);
        if (random <= 3f)
        {
            playerSound1.Play();
        }

        else
        {
            playerSound2.Play();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        Process();
        
        //Animate
        if (moveDirection > 0 && facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && !facingRight)
        {
            FlipCharacter();
        }
        
        // Running sounds test
        
        if(!runningSound.isPlaying && Input.GetKeyDown(KeyCode.A)){
            runningSound.Play();
            Debug.Log("A pressed");
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            runningSound.Stop();
        }
        
        if(!runningSound.isPlaying && Input.GetKeyDown(KeyCode.D)){
            runningSound.Play();
            Debug.Log("D pressed");
        }
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            runningSound.Stop();
        }
        
        
        // Moves the player
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }

    private void Process()
    {
        moveDirection = Input.GetAxis("Horizontal");
        Debug.Log(runningSound);
        // runningSound.Play();
        
        if (moveDirection == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);

        }
    }
    
    

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
