using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.
//###################################################################################################################################

public class HandgunReload : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public HandgunFire GunComponent;




	void Start ()
    {
        GunComponent = GetComponent<HandgunFire>();	
	}
	
	void Update () {

        ClipCount = GlobalAmmo.HGLoadedAmmo;
        ReserveCount = GlobalAmmo.HGCurrentAmmo;

        if(ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 10 - ClipCount;
        }

        if(Input.GetButtonDown("Reload"))
        {
            if(ReserveCount >=1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    GlobalAmmo.HGLoadedAmmo += ReserveCount;
                    GlobalAmmo.HGCurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.HGLoadedAmmo += ReloadAvailable;
                    GlobalAmmo.HGCurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
                
            }
            StartCoroutine(EnableScripts());
        }


	}

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<HandgunFire>().enabled = true;
        MechanicsObject.SetActive(true);
    }

    void ActionReload()
    {
        gameObject.GetComponent<HandgunFire>().enabled = false;


        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("HandgunReload");
    }
}
