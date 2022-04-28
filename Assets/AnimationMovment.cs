using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovment : MonoBehaviour
{
    bool grounded = false;

    //references
    Rigidbody2D rb2;
    SpriteRenderer sr;
    Animator a;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizvalue = Input.GetAxis("Horizontal");

        if (horizvalue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }

        rb2.velocity = new Vector2(horizvalue * 2, rb2.velocity.y);
        
        if (horizvalue < 0)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }

        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2.velocity = new Vector2(rb2.velocity.x, 6);
        }
    }
}
