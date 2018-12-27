using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################

public class ShotgunReload : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public ShotgunFire GunComponent;




	void Start ()
    {
        GunComponent = GetComponent<ShotgunFire>();	
	}
	
	void Update () {

        ClipCount = GlobalAmmo.SGLoadedAmmo;
        ReserveCount = GlobalAmmo.SGCurrentAmmo;

        if(ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 4 - ClipCount;
        }

        if(Input.GetButtonDown("Reload"))
        {
            if(ReserveCount >=1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    GlobalAmmo.SGLoadedAmmo += ReserveCount;
                    GlobalAmmo.SGCurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.SGLoadedAmmo += ReloadAvailable;
                    GlobalAmmo.SGCurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
                
            }
            StartCoroutine(EnableScripts());
        }


	}

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<ShotgunFire>().enabled = true;
        MechanicsObject.SetActive(true);
    }



    void ActionReload()
    {
        gameObject.GetComponent<ShotgunFire>().enabled = false;


        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("ShotgunReload");
    }

    
}
