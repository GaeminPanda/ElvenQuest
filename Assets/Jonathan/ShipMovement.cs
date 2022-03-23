using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipMovement : MonoBehaviour
{
    //public float rotateScale;
    //public float thrustScale;
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    public int bulletCount;
    public int xp;
    public GameObject AmmoMask;
    //public Text XPText;

    // Start is called before the first frame update
    void Start()
    {
        //rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //XPText.text = "XP: " + xp.ToString();

        //float rotation = rotateScale * Input.GetAxis("Horizontal");
        //transform.Rotate(new Vector3(0, 0, -rotation));

        //float thrust = thrustScale * Input.GetAxis("Vertical");
        //rb2.AddForce(transform.up * thrust);

        if(  (Input.GetButtonDown("Fire1") ||  Input.GetKeyDown(KeyCode.Space)) && bulletCount > 0  )
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            rb2bullet.AddForce(bulletSpeed * transform.up);
            Destroy(b, 5);
            bulletCount--;
            AmmoMask.GetComponent<MaskScript>().MoveMask(bulletCount, 10);
        }

        if(Input.GetKeyDown(KeyCode.R) && bulletCount < 1 )
        {
            bulletCount = 10;
            AmmoMask.GetComponent<MaskScript>().MoveMask(bulletCount, 10);
        }

    }
}
