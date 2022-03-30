using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float Hitpoints;
    public float MaxHitpoints = 20;
    public HealthbarBehavior Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    // Update is called once per frame
    void Update()
    {
        //Hitpoints -= damage;

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
