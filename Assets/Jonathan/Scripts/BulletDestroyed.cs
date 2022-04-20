using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        var enemy = collision.collider.GetComponent<EnemyBehaviour>();
        if (enemy)
        {
            Debug.Log("take hit");
            enemy.TakeHit(1);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

    }
}
