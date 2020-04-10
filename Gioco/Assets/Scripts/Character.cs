using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    /*
{
    public Rigidbody2D rb;
    public float jumpForce = 400f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Force);
            transform.localEulerAngles = new Vector3(0, 0, 15);
        } 
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}*/


public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    //public Animator anim;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    // Start is called before the first frame update
    private bool isdead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        //anim.SetBool("isgrounded", isTouchingGround);
        bool jetpackActive = Input.GetButton("Fire1");

        if (jetpackActive && isTouchingGround)
        {
            rb.AddForce(new Vector2(0, jumpForce));

        }
        if(isdead)
        {
            GameMaster.KillPlayer(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spike")
        {
            isdead = true;
        }
    }
}

