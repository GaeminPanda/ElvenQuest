using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Cage : MonoBehaviour
{
    public int test;
    [SerializeField]
    public GameObject[] enemies;
    SpriteRenderer spriteRenderer;
    public CommunityFollow elf;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        print(123);
        if(!enemies.ToList().Exists(x => x != null))
        {
            elf.inCage = false;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
