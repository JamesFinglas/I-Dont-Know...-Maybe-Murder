using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnDamage2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider e)
    {
        if(e.tag == "Player")
        {
            //InvokeRepeating("takeDamage", 1, 1);
            takeDamage();
            
        }

    }

    void takeDamage()
    {
        Inventory.health -= 10;
    }
}
