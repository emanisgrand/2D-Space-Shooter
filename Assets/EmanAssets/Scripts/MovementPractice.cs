using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 28.5f;
    public float rotateSpeed = 10.0f;
    Vector3 roof = new Vector3(0, 5, 0);

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT!");
        Descend();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position = transform.position + new Vector3(0, moveSpeed, 0)*Time.deltaTime;
            

            transform.position += Vector3.up * Time.deltaTime;
            transform.Rotate(0, 3, 0);
            transform.Translate(Vector3.up * Time.deltaTime);
        }
     }

    void Descend()
    {
        transform.position = transform.position + Vector3.down * Time.deltaTime;
        transform.Rotate(0, -3, 0);
    }
}
