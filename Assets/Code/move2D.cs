using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class move2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D MyRigidBody2D;
    [SerializeField] private int playerId;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;


    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // x will be set equal to -1 or 1
        // -1 if moving left
        // 1 if moving right
        float x = Input.GetAxisRaw("Horizontal");

        // Player 1 movement
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && playerId == 1)
        {
            Vector3 movement = new Vector3(x * speed, 0, 0); // Only changes the x value, the y and z values are adding 0
            movement *= Time.deltaTime;
            transform.Translate(movement);
            FlipPlayer(x);
        }

        // Player 2 movement
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && playerId == 2)
        {
            Vector3 movement = new Vector3(x * speed, 0, 0);
            movement *= Time.deltaTime;
            transform.Translate(movement);
            FlipPlayer(x);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigidBody2D.velocity = Vector2.up * jumpForce;
        }
    }

    // Make player face movement direction
    private void FlipPlayer(float x)
    {
        if (x > 0 && transform.localScale.x > 0)
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        else if (x < 0 && transform.localScale.x < 0)
            transform.localScale = new Vector2(Math.Abs(transform.localScale.x), transform.localScale.y);
    }
}
