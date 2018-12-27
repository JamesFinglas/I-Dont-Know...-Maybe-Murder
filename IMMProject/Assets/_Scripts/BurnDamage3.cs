using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnDamage3 : MonoBehaviour {

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
            InvokeRepeating("TakeDamage", 1, 1);
            
            
        }

    }

    void TakeDamage()
    {
        Inventory.health -= 40;
    }
}
