using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    //public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    public GameObject gun;
    private float xGun;
    public float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        xGun = gun.transform.localPosition.x;
    }

    private void FixedUpdate()
    {

        //Move right
        if(Input.GetAxis("Horizontal")>0)
        {
            float currentSpeed = speed;
            sr.flipX = true;
            gun.transform.localPosition = new Vector3(xGun, gun.transform.localPosition.y, gun.transform.localPosition.z);
            //rb2.AddForce(new Vector2(accel, 0));
            rb2.MovePosition(transform.position + (new Vector3(currentSpeed, 0, 0) * Time.deltaTime));
        }
        //Move left
        if (Input.GetAxis("Horizontal") < 0)
        {
            float currentSpeed = -speed;
            sr.flipX = false;
            gun.transform.localPosition = new Vector3(-xGun, gun.transform.localPosition.y, gun.transform.localPosition.z);
            //rb2.AddForce(new Vector2(-accel, 0));
            rb2.MovePosition(transform.position + (new Vector3(currentSpeed, 0, 0) * Time.deltaTime));
        }
    }
}