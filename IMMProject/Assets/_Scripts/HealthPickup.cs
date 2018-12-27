using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################


public class HealthPickup : MonoBehaviour {


    public AudioSource HealthSound;



    private void OnTriggerEnter(Collider other)
    {
        

        // Handgun

        if (Inventory.health < 100)
        {
            HealthSound.Play();
            Inventory.health += 30;
            if(Inventory.health > 100)
            {
                Inventory.health = 100;
            }
            this.gameObject.SetActive(false);
        }
        else
        {
            
        }
    }

    public void Update()
    {
        transform.Rotate(0f, 1f, 0f);
    }
}
