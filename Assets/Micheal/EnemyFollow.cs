using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    private SpriteRenderer sr;

    Rigidbody2D rb2;
    public Transform PatrolPointOne;
    public Transform PatrolPointTwo;

    public float speed = 50;

    private bool GoingLeft = true;
    private bool patroling = true;

    private GameObject player;

    private bool FollowingLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(patroling);

        if (patroling)
        {
            float currentSpeed = speed;

            if (GoingLeft)
            {
                currentSpeed = -speed;
            }

            rb2.MovePosition(transform.position + (new Vector3(currentSpeed, 0, 0) * Time.deltaTime));

            if (transform.position.x > PatrolPointTwo.position.x)
            {
                GoingLeft = true;
                sr.flipX = true;
            }
            else if (transform.position.x < PatrolPointOne.position.x)
            {
                GoingLeft = false;
            }

            RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 100);

            if (hit.transform.tag == "Player" && (player.transform.position - transform.position).magnitude < 30)
            {
                patroling = false;
            }

            Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red, 1);
            
        }
        else
        {
            float currentSpeed = speed;

            if (FollowingLeft)
            {
                currentSpeed = -speed;
            }

            rb2.MovePosition(transform.position + (new Vector3(currentSpeed, 0, 0) * Time.deltaTime));

            if (transform.position.x > player.transform.position.x)
            {
                FollowingLeft = true;
            }
            else if (transform.position.x < player.transform.position.x)
            {
               FollowingLeft = false;
            }

            RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 100);

            if (hit.transform.tag != "Player" || (player.transform.position - transform.position).magnitude > 10)
            {
                patroling = true;
            }

            Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.blue, 1);
        }
    }
}
