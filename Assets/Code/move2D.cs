using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2D : MonoBehaviour
{
    public Rigidbody2D MyRigidBody2D;
    [SerializeField] private int playerId;
    [SerializeField] private float speed = 5f;


    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            float x = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(x, transform.position.y, transform.position.z);
            transform.Translate(movement * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.D))
        {
            float x = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(x * speed * Time.deltaTime, transform.position.y, transform.position.z);
            transform.Translate(movement);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigidBody2D.velocity = Vector2.up * 10;
        }ign
    }
}