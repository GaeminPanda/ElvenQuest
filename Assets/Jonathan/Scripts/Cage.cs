using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Cage : MonoBehaviour
{
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
        
        if(!enemies.ToList().Exists(x => x != null))
        {
            elf.inCage = false;
            Destroy(gameObject);
        }
    }
    
}
