using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;

    public int shootButton;
    public KeyCode reloadKey;

    void Update()
    {
        if (Input.GetMouseButton(shootButton))
        {
            gun.Shoot();
        }

        if (Input.GetKeyDown(reloadKey))
        {
            gun.Reload();
        }
    }
}
