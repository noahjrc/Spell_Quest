using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
    {
        void Move(float Direction);
    }

public class PlayerMovement : MonoBehaviour, IMovement
{
    //private means only this script can access RigidBody// 
    private Rigidbody2D rb;
    private BoxCollider2D collider;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;
    [SerializeField]private float MoveSpeed = 7f;
    [SerializeField]private float JumpForce = 5f;

    private enum MovementState {idle, running, jumping, falling}

    [SerializeField] private AudioSource JumpSoundEffect;

    /*
    
    This lets it show up in the unity editor tab
    [SerializeField] private float MoveSpeed = 7f;

    OR

    public float MoveSpeed = 7f;

    

    */


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame//
    private void Update()
    {   

        dirX = Input.GetAxisRaw("Horizontal");

        //OCP Employed here 
        Move(dirX);
        //rb.velocity = new Vector2(dirX * MoveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            //4f is just a float
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            JumpSoundEffect.Play();
        }

        UpdateAnimationState();
        
    }

    public void Move(float direction)
    {
        rb.velocity = new Vector2(direction * MoveSpeed, rb.velocity.y);
    }


    private void UpdateAnimationState()
    {
        MovementState state;
        //This allows us to change from idle animation to running animation//
        //In the positive right direction//
        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }

        //For the negative/left direction
        else if(dirX < 0f)
        {
            state = MovementState.running;
            //Flip the sprite on the x axis/ turn it around
            sprite.flipX = true;
            
        }

        //If were not moving at all, idle
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > 0.0001f)
        {
            state = MovementState.jumping;
        }

        else if (rb.velocity.y < -0.0001f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }


    private bool IsGrounded()
    {
        return Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
    

    
}
