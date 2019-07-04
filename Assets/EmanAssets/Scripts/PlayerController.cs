using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public members
    public float moveSpeed;
    public float turnSpeed;

    // Private members
    private bool isMoving = false;
    private Rigidbody2D shipRb;

    // Start is called before the first frame update
    void Awake()
    {
        shipRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    private void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        if(isMoving == true)
        {
            shipRb.AddTorque(-turn * turnSpeed);
            shipRb.AddForce(transform.up * moveSpeed);
        }
    }
}
