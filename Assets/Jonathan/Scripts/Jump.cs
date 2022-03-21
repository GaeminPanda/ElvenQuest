using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpStrength = 400;
    public bool grounded;
    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb2.AddForce(new Vector2(0, jumpStrength));
        }
    }

        private void OnTriggerStay2D(Collider2D collision)
        {
            grounded = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            grounded = false;
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag == "SuperJump")
        {
            jumpStrength = 1000;
        } else
        {
            jumpStrength = 400;
        }
    }

}
