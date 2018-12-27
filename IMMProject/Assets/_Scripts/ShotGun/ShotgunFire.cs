using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################


public class ShotgunFire : MonoBehaviour
{

    public AudioSource fire;
    public AudioSource tick;
    public AudioSource reload2;

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

            if (GlobalAmmo.SGLoadedAmmo >= 1)
            {

                fire.Play();

                Animation anim = gameObject.GetComponent<Animation>();
                anim.Play();
                GlobalAmmo.SGLoadedAmmo -= 1;

                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    print("Shotgun Hit");
                    targetDistance = Shot.distance;
                    if (targetDistance < allowedRange)
                    {
                        Shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }

                ActionReload2();
                EnableScripts2();
            }

            else
            {


                tick.Play();


            }

        }
    }

    IEnumerator EnableScripts2()
    {
        yield return new WaitForSeconds(0.5f);
       // gameObject.GetComponent<ShotgunFire>().enabled = true;
    }

    public void ActionReload2()
    {
       // gameObject.GetComponent<ShotgunFire>().enabled = false;


        reload2.Play();
        GetComponent<Animation>().Play("ShotgunFire");
    }
}


