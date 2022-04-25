using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    private float horizontalMovement;
    private bool jumKeyWasPressed;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private LayerMask jumpableGround;

    private enum MovementState { Idle, Running, Jumping, Falling }
    
    // Start is called before the first frame update
    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update() 
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            jumKeyWasPressed = true;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMovement * moveSpeed, rb.velocity.y);

        if (jumKeyWasPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumKeyWasPressed = false;
        }
        
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        
        if (horizontalMovement > 0f)
        {
            state = MovementState.Running;
            sprite.flipX = false;
        }
        else if (horizontalMovement < 0f)
        { 
            state = MovementState.Running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.Idle;
        }

        if (rb.velocity.y > .1f && !isGrounded())
        {
            state = MovementState.Jumping;
        } else if (rb.velocity.y < -.1f && !isGrounded())
        {
            state = MovementState.Falling;
        }
        
        anim.SetInteger("state", (int)state);
    }

    private bool isGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
