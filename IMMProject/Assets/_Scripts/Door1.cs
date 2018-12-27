using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour {

   

    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(Inventory.keycard >= 2)
        {
            Destroy(gameObject);

        }
    }
}
