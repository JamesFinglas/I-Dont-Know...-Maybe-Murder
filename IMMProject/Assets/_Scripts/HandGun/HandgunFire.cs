using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour            
    //###################################################################################################################################
    // Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
    // Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.
    //###################################################################################################################################
                                                                
{

    public AudioSource fire;
    public AudioSource tick;

    public int damageAmount = 5;
    public float targetDistance;
    public float allowedRange;


    void Start()
    {
        // cant...stop...doing...the ...MONKEY!!!!
        // by request of james this comment cannot be removed.
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            if (GlobalAmmo.HGLoadedAmmo >= 1)
            {

                fire.Play();

                Animation anim = gameObject.GetComponent<Animation>();
                anim.Play();
                GlobalAmmo.HGLoadedAmmo -= 1;

                print("yo");
                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    print("yo222");
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


