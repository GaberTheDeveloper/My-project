using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D MyRigidBody2D;
    [SerializeField] private int playerId;
    [SerializeField] private float speed = 5f;


    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A) && playerId == 1)
        {
            Vector3 movement = new Vector3(x * speed, 0, 0);
            movement *= Time.deltaTime;
            transform.Translate(movement);
        } else if (Input.GetKey(KeyCode.D) && playerId == 1)
        {
            Vector3 movement = new Vector3(x * speed, 0, 0);
            movement *= Time.deltaTime;
            transform.Translate(movement);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigidBody2D.velocity = Vector2.up * 10;
        }
    }
}
