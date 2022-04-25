using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovment : MonoBehaviour
{
    bool grounded = false;

    //references
    Rigidbody2D rb2;
    Spriterenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameobject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
