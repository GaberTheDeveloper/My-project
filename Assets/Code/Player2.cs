using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D MyRigidBody2D;

    // Update is called once per frame

public float speed = 5;
void Update()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        float x1 = Input.GetAxis("Horizontal");
        float z1 = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x1, 0, z1);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}