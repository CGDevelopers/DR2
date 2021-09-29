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

    private void OnCollisionEnter2D(Collision2D col){

        Grounded = true;
    }

    private void OnCollisionExit2D(Collision2D col){
        Grounded = false;
    }

     void Update()
    {
        // Movimiento
        Horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(mySpriteRenderer != null)
            {
                 // Girar el sprite
                 mySpriteRenderer.flipX = true;
            }


        }
        if(Input.GetKeyDown(KeyCode.D) | Input.GetKeyDown(KeyCode.RightArrow))
        {
                // Girar el sprite
                mySpriteRenderer.flipX = false;
        }

        Animator.SetBool("Running", Horizontal != 0.0f);

        // Salto
        if (Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.UpArrow) && Grounded == true)
        {
            if(Grounded == true){
            Jump();
            }
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