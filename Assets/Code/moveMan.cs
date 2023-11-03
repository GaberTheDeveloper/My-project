using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMan : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float timeMax = 9;
    public float Timer = 8;
    public float speed = 8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        handleKeys();
    }
        void handleKeys()
        {
            if (Input.GetKey(KeyCode.A) == true)
            {
                transform.Translate(Vector3.left);
            }

            if (Input.GetKey(KeyCode.D) == true)
            {
                transform.Translate(Vector3.right);
            }
        }

}



