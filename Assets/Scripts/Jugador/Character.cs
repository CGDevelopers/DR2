using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character: MonoBehaviour
{
    private static Character instance;
    public static int vida;
    private Controlador gm;

    //Variables de movimiento 
    public float Speed;
    public float SpeedJump;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private SpriteRenderer mySpriteRenderer;
    private float Horizontal;
    private bool Grounded;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        SpeedJump = 1.3333334f;
        vida = PlayerPrefs.GetInt("Dificultad");
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<Controlador>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Grounded = true;

        if (col.gameObject.tag == "DeathZone")
        {
            vida = vida - 1;
            transform.position = gm.CheckPointActual;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
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
            if(Grounded == true)
            {
            Jump();
            }
        }

        //Comprobar la cantidad de vidas
        if(vida == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);

        if (Grounded == false)
        {
            Rigidbody2D.velocity = new Vector3(Horizontal * Speed / SpeedJump, Rigidbody2D.velocity.y);
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
}