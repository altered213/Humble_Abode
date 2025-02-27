using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 12.0f;
    public BoxCollider2D groundCollider;
    public SpriteRenderer sr;
    public Animator animator;
    public GameObject AttackPoint;

    private Rigidbody rb;
    private const float gravity = 2.0f;

    // Improvements to consider:
    // - Double jump
    // - Easing into movement (accelerating more slowly)

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Player Move Anim");
            transform.position += Vector3.left * speed * Time.deltaTime;
            sr.flipX = true;
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Player Move Anim");
            transform.position += Vector3.right * speed * Time.deltaTime;
            sr.flipX = false;
        }
        else
        {
            animator.Play("Idle animation Player");
        }
        

        
        if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        
    }

    private bool IsGrounded()
    {
        return groundCollider.IsTouchingLayers(LayerMask.GetMask("Ground"));
    }
}
