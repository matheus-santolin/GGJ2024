using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce;
    public float rotationSpeed = 300f;

    public Rigidbody _RB;
    public bool isGrounded;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _RB.AddForce(_RB.transform.forward * speed * 1.5f);
            }
            else
            {
                _RB.AddForce(_RB.transform.forward * speed);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            _RB.AddForce(-_RB.transform.right * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _RB.AddForce(-_RB.transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _RB.AddForce(_RB.transform.right * speed);
        }

        if (Input.GetAxis("Jump") > 0) 
        {
            if (isGrounded) 
            {
                _RB.AddForce(new Vector3(0f, jumpForce, 0f));
                isGrounded = false;
            }
            
        }
    }
}
