using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public Rigidbody2D rb;
    [Header("Move Mechanics")]
    public Transform personajeTransform;
    public float speedPersonaje;

    [Header("Jump Mechanics")] 
    [Range(1, 20)]
    public float strenghJump;
    public float fallMultipler = 2.5f;
    public float lowJumpMultipler = 2;
    public bool isGrounded = true;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            personajeTransform.Translate((Vector2.right * Time.deltaTime * speedPersonaje));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            personajeTransform.Translate((Vector2.left * Time.deltaTime * speedPersonaje));
        }
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultipler - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultipler - 1) * Time.deltaTime;
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * strenghJump; 
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
}
