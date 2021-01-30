using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;

    // Called after all objects are initialized.
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component
    }
    

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
        
        // Moves the player
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }
}
