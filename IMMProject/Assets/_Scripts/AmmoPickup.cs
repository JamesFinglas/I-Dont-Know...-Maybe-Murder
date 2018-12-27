using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################


public class AmmoPickup : MonoBehaviour {


    public AudioSource AmmoSound;
   
    

    private void OnTriggerEnter(Collider e)
    {
        if (e.tag == "Player")
        {
            AmmoSound.Play();

            // Handgun

            if (GlobalAmmo.HGLoadedAmmo == 0)
            {
                GlobalAmmo.HGLoadedAmmo += 10;
                this.gameObject.SetActive(false);
            }
            else
            {
                GlobalAmmo.HGCurrentAmmo += 10;
                this.gameObject.SetActive(false);
            }

            // Shotgun

            if (GlobalAmmo.SGLoadedAmmo == 0)
            {
                GlobalAmmo.SGLoadedAmmo += 4;
                GlobalAmmo.SGCurrentAmmo += 6;
                this.gameObject.SetActive(false);
            }
            else
            {
                GlobalAmmo.SGCurrentAmmo += 10;
                this.gameObject.SetActive(false);
            }

            // Machginegun

            if (GlobalAmmo.MGLoadedAmmo == 0)
            {
                GlobalAmmo.MGLoadedAmmo += 10;
                this.gameObject.SetActive(false);
            }
            else
            {
                GlobalAmmo.MGCurrentAmmo += 10;
                this.gameObject.SetActive(false);
            }

        }

    }

    public void Update()
    {
        transform.Rotate(0f, 1f, 0f);
    }
}
