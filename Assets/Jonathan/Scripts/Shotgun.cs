using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    public int bulletCount;
    float spray;
    float bulletspeed;
    public GameObject mainplayer;



    void Update()
    {
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            for (int i = 0; i < 12; i++)
            {
                Shoot();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reloadtimer());
        }

    }
    IEnumerator reloadtimer()
    {
        yield return new WaitForSeconds(.5f);
        bulletCount = 36;
    }
    void Shoot()
    {
        //GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        //Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
        //spray = Random.Range(-1.5f, 4.5f);
        //bulletspeed = Random.Range(10, 15);
        //rb2bullet.AddForce(bulletSpeed * (transform.forward + new Vector3(bulletspeed, spray, 0)));

        //bulletCount--;
        SpriteRenderer sr;
        sr = mainplayer.GetComponent<SpriteRenderer>();
        if (sr.flipX == true)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            spray = Random.Range(-1.5f, 4.5f);
            bulletspeed = Random.Range(10, 15);
            rb2bullet.AddForce(bulletSpeed * (transform.forward + new Vector3(bulletspeed, spray, 0)));

            bulletCount--;
        }
        if (sr.flipX == false)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            spray = Random.Range(-1.5f, 4.5f);
            bulletspeed = Random.Range(10, 15);
            rb2bullet.AddForce(-bulletSpeed * (transform.forward + new Vector3(bulletspeed, spray, 0)));

            bulletCount--;
        }
    }

}
