using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################


public class MachineGunFire : MonoBehaviour
{

    public AudioSource fire;
    public AudioSource tick;
    

    public int damageAmount = 5;
    public float targetDistance;
    public float allowedRange;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            if (GlobalAmmo.MGLoadedAmmo >= 1)
            {

                fire.Play();

                Animation anim = gameObject.GetComponent<Animation>();
                anim.Play();
                GlobalAmmo.MGLoadedAmmo -= 1;

                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    print("Machinegun Hit");
                    targetDistance = Shot.distance;
                    if (targetDistance < allowedRange)
                    {
                        Shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }

                
            }

            else
            {


                tick.Play();


            }

        }
    }


}


