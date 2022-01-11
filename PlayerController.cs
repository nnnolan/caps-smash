using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D collider;
    public float JumpForce = 4f;
    public float MoveSpeed = 5f;
    bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        bool isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        if (isJumping == false && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.transform.up * JumpForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(rb.transform.right * -MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(rb.transform.right * MoveSpeed);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            bool isJumping = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            bool isJumping = true;
        }
       
    }
}
