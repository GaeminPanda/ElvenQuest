using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public bool facingRight = false;
    public LayerMask whatIsGround;

    public bool isGround = false;
    public bool isFalling = false;
   public bool isJumping = false;

    public float jumpForceX = 2f;
    public float jumpForceY = 4f;

   public float lastYPos = 0;

    public enum Animations
    {
       Idle = 0,
        Jumping = 1,
        Falling = 2
    };

    public Animations currntAnim;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator anim;



// Start is called before the first frame update
void Start()
{
        lastYPos = transform.position.y;
        rb = GetComponent < Rigidbody2D();

}

// Update is called once per frame
void Update()
{

}
}
