using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private SpriteRenderer mySpriteRenderer;
    private float Horizontal;
    private bool Grounded;
    
     void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

     void Update()
    {
        // Movimiento
        Horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown(KeyCode.A))
        {
            if(mySpriteRenderer != null)
            {
                 // Girar el sprite
                 mySpriteRenderer.flipX = true;
            }


        }
        if(Input.GetKeyDown(KeyCode.D))
        {
                // Girar el sprite
                mySpriteRenderer.flipX = false;
        }

        Animator.SetBool("Running", Horizontal != 0.0f);

        // Detectar Suelo
        // Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else Grounded = false;

        // Salto
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }

    }
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
}