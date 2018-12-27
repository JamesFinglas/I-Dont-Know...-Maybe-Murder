using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//###################################################################################################################################
// Tutorial used for this script, C/O Jimmy Vegas https://www.youtube.com/watch?v=0fGB2H1AGP8&list=PLZ1b66Z1KFKh-auyvzNkOBFLWf6dH6iEH
// Its a basic tutorial that taught me how to make health for enemies, shoot guns , ammo and ammo pickups.

// Using his code i made my own "Shotgun and Machinegun" Weapons with different damages and ranges.
//###################################################################################################################################

public class EnemyScript : MonoBehaviour {

    public int EnemyHealth = 10;

    void DeductPoints(int DamageAmout)
    {
        EnemyHealth -= DamageAmout;
        print("DamageAmount");
    }





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyHealth <=0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter(Collider e)
    {
        if(e.tag == "Player")
        {
            InvokeRepeating("takeDamage", 0.5f, 1);
        }
        else if(e.tag != "Player")
        {
            CancelInvoke();
        }
        
     
    }

    void takeDamage()
    {
        Inventory.health -= 15;
    }



}
