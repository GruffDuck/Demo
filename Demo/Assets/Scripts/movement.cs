using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float MovementSpeed=1;
    public Animator anim;
    bool isFacingRight = true;
    private Rigidbody2D rb;
    private bool isgrounded;
    public float jumpforce = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        
        if (isFacingRight && movement < 0 || !isFacingRight && movement >0 )
            Flip();
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool(("run"),true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool(("run"),false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isgrounded == true)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
               
                anim.SetBool("jump",true);
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("jump", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isgrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isgrounded = false;
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
}
