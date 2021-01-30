using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove;
    public float moveSpeed;
    private Rigidbody2D rb;
    private float moveDirection;

    // Called after all objects are initialized.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component
        canMove = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
        
        // Moves the player
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }
}
