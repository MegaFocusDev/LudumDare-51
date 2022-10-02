using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    public int jumpCount;
    private int remainingJumps;
    public Audiomanager audiomanager;
    private Rigidbody2D rb;
    private bool isGrounded; public float checkRadius;
    public LayerMask whatIsGround;
    public Transform check;
    private bool facingRight = true;
    private void Start()
    {
        remainingJumps = jumpCount;
        rb = GetComponent<Rigidbody2D>();
        audiomanager = FindObjectOfType<Audiomanager>();
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(check.position, checkRadius, whatIsGround);
        if(isGrounded)remainingJumps = jumpCount;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }
    public void gravityChange()
    {
        rb.gravityScale *= -1;
        check.localPosition = new Vector2(check.localPosition.x, check.localPosition.y*-1);
        audiomanager.Play("Gravity");
    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(facingRight == false && moveInput > 0)
        {
            flip();
        } else if(facingRight == true && moveInput < 0)
        {
            flip();
        }
    }
    private void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    public void jump()
    {
        if(remainingJumps > 0 && rb.gravityScale >0)
        {
            rb.velocity = Vector2.up * jumpForce;
            remainingJumps--;
            audiomanager.Play("Jump");
        }else if(remainingJumps >0 && rb.gravityScale < 0)
        {
            rb.velocity = Vector2.down * jumpForce;
            remainingJumps--;
            audiomanager.Play("Jump");
        }
    }
}
