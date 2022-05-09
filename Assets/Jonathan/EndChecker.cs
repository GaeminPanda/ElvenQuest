using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndChecker : MonoBehaviour
{

    public GameObject player;
    public float totalDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalDistance = 0;
        GameObject[] Elfs = GameObject.FindGameObjectsWithTag("Elf");
        foreach(GameObject elf in Elfs)
        {
            totalDistance += Vector3.Distance(player.transform.position, elf.transform.position);
        }
    }
}
